using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compiler.Utils
{
    /// <summary>
    /// Standard Digraph
    /// </summary>
    /// <typeparam name="T">type of the graph nodes</typeparam>
    public class Graph<T>
    {
        #region Fields

        enum Color { WHITE = 0, GRAY = 1, BLACK = 2 };

        Dictionary<T, LinkedList<T>> adjacencyList;

        #endregion

        #region Constructors
        public Graph()
        {
            adjacencyList = new Dictionary<T, LinkedList<T>>();
        } 
        #endregion

        #region Properties

        /// <summary>
        /// Vertex count
        /// </summary>
        public int VertexCount
        {
            get { return adjacencyList.Count; }
        }

        /// <summary>
        /// Edge count
        /// </summary>
        public int EdgeCount
        {
            get
            {
                int totalEdges = 0;
                foreach (var item in adjacencyList)
                {
                    totalEdges += item.Value.Count;
                }

                return totalEdges;
            }
        } 

        #endregion

        #region Methods

        /// <summary>
        /// Adds a vertex to the graph
        /// </summary>
        /// <param name="v">vertex</param>
        /// <returns>True if succeded, False otherwise</returns>
        public bool AddVertex(T v)
        {
            try
            {
                adjacencyList.Add(v, new LinkedList<T>());
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Adds an edge to the graph
        /// </summary>
        /// <param name="v1">vertex from</param>
        /// <param name="v2">vertex to</param>
        /// <returns>True if succeded, False otherwise</returns>
        public bool AddEdge(T v1, T v2)
        {
            ///si el vertice no existe
            if (!adjacencyList.ContainsKey(v1))
                return false;

            LinkedList<T> adjacents;
            bool succedded = adjacencyList.TryGetValue(v1, out adjacents);

            ///si hubo problemas encontrando los adyacentes
            if (!succedded)
                return false;

            ///si la arista ya estaba
            if (adjacents.Contains(v2))
                return false;

            ///lo agregamos a la lista
            adjacents.AddLast(v2);

            return true;
        }

        /// <summary>
        /// Gets the adjacents to a vertex
        /// </summary>
        /// <param name="v">vertex to get adjacents from</param>
        /// <returns></returns>
        public IEnumerable<T> Adjacents(T v)
        {
            if (!adjacencyList.ContainsKey(v))
                yield break;

            foreach (T vertex in adjacencyList[v])
                yield return vertex;
        }

        /// <summary>
        /// Determines wheter this graph has a cycle
        /// </summary>
        /// <returns>True if G has cycle, False otherwise</returns>
        public bool HasCycle()
        {
            if (VertexCount == 0)
                return false;

            Dictionary<T, Color> color = new Dictionary<T, Color>();
            Dictionary<T, int> prof = new Dictionary<T, int>();
            foreach (T vertex in adjacencyList.Keys)
            {
                color.Add(vertex, Color.WHITE);
                prof.Add(vertex, 0);
            }

            foreach (T u in adjacencyList.Keys)
            {
                if (color[u] == Color.WHITE)
                {
                    if (HasCycle(u, color, prof))
                        return true;
                }
            }

            return false;
        }

        private bool HasCycle(T u, Dictionary<T, Color> color, Dictionary<T, int> prof)
        {
            //lo estamos procesando
            color[u] = Color.GRAY;

            foreach (T v in Adjacents(u))
            {
                if (color[v] == Color.WHITE)
                {
                    prof[v] = prof[u] + 1;

                    if (HasCycle(v, color, prof))
                        return true;
                }
                else if (color[v] == Color.GRAY && prof[u] - prof[v] >= 1)
                    return true;
            }

            color[u] = Color.BLACK;
            return false;
        } 

        #endregion
    }
}
