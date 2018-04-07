grammar TigerGrammar;

options
{
	language = CSharp3;
	output = AST;
	k = 1;
}

tokens
{
	/*KEYWORDS*/
	ARRAY = 'array';
	IF = 'if';
	THEN = 'then';
	ELSE = 'else';
	WHILE = 'while';
	FOR = 'for';
	TO = 'to';
	DO = 'do';
	LET = 'let';
	IN = 'in';
	END = 'end';
	OF = 'of';
	BREAK = 'break';
	NIL = 'nil';
	FUNCTION = 'function';
	VAR = 'var';
	TYPE = 'type';

	 /*PUNCTUATION SYMBOLS*/
	 DOT = '.';
	 COMMA = ',';
	 COLON = ':';
	 SEMICOLON = ';';
	 L_PARENT = '(';
	 R_PARENT = ')';
	 L_BRACKET = '[';
	 R_BRACKET = ']';
	 L_BRACE = '{';
	 R_BRACE = '}';
	 PLUS='+';
	 MINUS='-';
	 MULT = '*';
	 DIV = '/';
	 
	 EQUALS = '=';
	 NOT_EQUALS = '<>';
	 LESS = '<';
	 LESS_EQUALS = '<=';
	 GREATER = '>';
	 GREATER_EQUALS = '>=';
	 AND = '&';
	 OR = '|';
	 ASSIGN = ':=';
	 
	 OPEN_COMMENT = '/*';
	 CLOSE_COMMENT = '*/';
	 
	 /*AST*/
	 TYPED_VAR_DECLARATION;
	 INFERRED_VAR_DECLARATION;
	 
	 RECORD_DECLARATION;
	 ALIAS_DECLARATION;
	 ARRAY_DECLARATION;

	 ARRAY_CREATION;	 
	 RECORD_CREATION;

	 FUNCTION_DECLARATION;
	 PROCEDURE_DECLARATION;

	 CALLABLE_CALL;

	 MINUS_UNARY;

	 RECORD_ACCESS;
	 ARRAY_ACCESS;

	 LVALUE_ID;
	 
	 IF_THEN;
	 IF_THEN_ELSE;
	 
	 DECLARATION_LIST;
	 EXPR_SEQ;
}

//------------------------------------------------------------------------------------------------------

/*PARSER*/
public program
	:       
		expr EOF!
	;

expr 		options {backtrack = true; memoize = true;}
	:	array_creation
	      | assign_expr	
	      | expr_or
	      | control_instr
	      | let_in_end
	;
	
expr_or	
	:	
		expr_and (OR^ expr_and)*
	;

expr_and
	:	
		expr_rel (AND^ expr_rel)*
	;

expr_rel
	:	
		expr_arit ((EQUALS^ |  NOT_EQUALS^ | LESS^ | LESS_EQUALS^ | GREATER^ | GREATER_EQUALS^) expr_arit)?
	;

expr_arit
	:	
		term ((MINUS^ | PLUS^) term)*
	;

term	
	:	
		factor ((MULT^ | DIV^) factor)*
	;

factor	
	:
		 MINUS f = unsigned_factor -> ^(MINUS_UNARY $f)
	       | unsigned_factor
	;

unsigned_factor 
	: 
		constant
	      | lvalue
	;

constant
	:
		NIL^
	      | INT^
	      | STRING^		
	;

minus_expr
	:	
		MINUS e = expr -> ^(MINUS_UNARY $e)
	;

control_instr
	:	
		WHILE^ expr DO! expr	
	      | FOR^ ID ASSIGN! expr TO! expr DO! expr
	      |(IF expr THEN expr ELSE) => IF e1 = expr THEN e2 = expr ELSE e3 = expr -> ^(IF_THEN_ELSE $e1 $e2 $e3)
	      | IF e1 = expr THEN e2 = expr -> ^(IF_THEN $e1 $e2) 	
	      | BREAK^ 
	;

let_in_end
	:	
		LET (d = declarationList) IN (e_seq1 = expr_seq)? END ->^(LET ^(DECLARATION_LIST $d) ^(EXPR_SEQ $e_seq1?))
	;

array_creation 
	: 
		id1 = ID L_BRACKET e1 = expr R_BRACKET OF e2 = expr -> ^(ARRAY_CREATION $id1 $e1 $e2)
	;

assign_expr
	:	
		l = lvalue ASSIGN e = expr -> ^(ASSIGN $l $e)
	;

lvalue
	:
	       (
		    //EXPRESSION BLOCK
		    (L_PARENT (e_seq = expr_seq)? R_PARENT -> ^(EXPR_SEQ $e_seq?))
		        
		    //RECORD CREATION
	          | (ID L_BRACE) => (t = type_id L_BRACE (f = field_list)? R_BRACE -> ^(RECORD_CREATION $t $f?))
		      	
		    //CALLABLE CALL
	          | (ID L_PARENT) => (id_callable = ID L_PARENT (callable_args = expr_list)? R_PARENT -> ^(CALLABLE_CALL $id_callable $callable_args?))
		      	
	     	    //ID
	          | ((id = ID) -> ^(LVALUE_ID $id))
	        )
		    //TAIL
		(	
		    DOT id2 = ID -> ^(RECORD_ACCESS $lvalue $id2)
		  | L_BRACKET e = expr R_BRACKET -> ^(ARRAY_ACCESS $lvalue $e)
		)*

	;

declarationList	
	: 
		( type_declaration | variable_declaration | callable_declaration )+
	;

type_declaration 
	: 
		TYPE id1 = type_id EQUALS 
		(	
			//ALIAS DECLARATION
		   	id2 = type_id -> ^(ALIAS_DECLARATION $id1 $id2)
		   	//RECORD DECLARATION
		      | L_BRACE (type_fields)? R_BRACE -> ^(RECORD_DECLARATION $id1 type_fields?) 
		      	//ARRAY DECLARATION
		      | ARRAY OF id3 = type_id -> ^(ARRAY_DECLARATION $id1 $id3)
		 )
	;

type_id	
	:
		ID 
	;

type_fields 
	: 
		type_field (COMMA! type_field)*
	;

type_field 
	: 
		ID COLON! type_id
	; 

variable_declaration 
	: 
		VAR id1 = ID (COLON id2 = type_id ASSIGN e = expr -> ^(TYPED_VAR_DECLARATION $id1 $id2 $e) 
						| ASSIGN e = expr -> ^(INFERRED_VAR_DECLARATION $id1 $e))
	;  

callable_declaration 
	: 
		FUNCTION id1 = ID L_PARENT (t = type_fields)? R_PARENT 
		(COLON t1 = type_id EQUALS e = expr -> ^(FUNCTION_DECLARATION $id1 $t? $t1 $e) | EQUALS e = expr ->^(PROCEDURE_DECLARATION $id1 $t? $e))
	; 

expr_list 
	: 
		expr (COMMA! expr)*
	; 
	
expr_seq 
	: 
		expr (SEMICOLON! expr)*
	; 

field_list 
	: 
		ID EQUALS! expr (COMMA! ID EQUALS! expr)*
	; 				
		
//------------------------------------------------------------------------------------------------------

/*LEXER*/
ID 
	:   
		LETTER (LETTER | DEC_DIGIT | '_')*
	;
    
fragment
LETTER 	
	:
		('a'..'z'|'A'..'Z')
	;	

/*representa un entero sin signo*/
INT 
	:	
		DEC_DIGIT+
    	;    

//Generado con el Wizard de AntlrWorks 1.4.2( agregamos COMMENT | )
COMMENT
	:   
    		OPEN_COMMENT ( options {greedy=false;} : COMMENT | . )* CLOSE_COMMENT {$channel = Hidden;}
    	;

//Generado con el Wizard de AntlrWorks 1.4.2
WS  
	:  
		( ' ' | '\t' | '\r' | '\n')+ {$channel = Hidden;}
    	;

STRING
    	:  
    		'"' ( ESC_SEQ | ~('\\' | '"') )* '"'
    	;

fragment
DEC_DIGIT 
	: 
		('0'..'9') 
	;

fragment
HEX_DIGIT 
	: 
		('0'..'9'|'a'..'f'|'A'..'F')
	;

fragment
ESC_SEQ
    	:   
    		'\\' 
    		('n' 					| 
    		 't' 					| 
    		 'r' 					| 
    		 '"' 					| 
    		 '\\'					| 
    		 '^'('@'..'_') 				| 
    		 ASCII_ESC		 		|
    		 (WS)+ '\\'
    		)
    	;

fragment
ASCII_ESC
	:	
		DEC_DIGIT DEC_DIGIT DEC_DIGIT
	;