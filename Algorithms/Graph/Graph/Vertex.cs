using System;
using System.Collections.Generic;

namespace Graph
{
    public class Vertex
    {
        public Vertex(string value)
        {
            Value = value;
            AdjacentVertexes = new List<Vertex>();
        }

        public List<Vertex> AdjacentVertexes { get; set; }
        public string Value { get; set; }

        public static void DepthFirstTraverse(Vertex startVertex, IDictionary<Vertex, bool> visitedVertices, Action<Vertex> outputProc)
        {
            visitedVertices[startVertex] = true;

            outputProc?.Invoke(startVertex);
            foreach (var vertex in startVertex.AdjacentVertexes)
            {
                if (!visitedVertices.ContainsKey(vertex))
                {
                    DepthFirstTraverse(vertex, visitedVertices, outputProc);
                }
            }
        }

        public static Vertex DepthFirstSearch(Vertex startVertex, string searchValue, IDictionary<Vertex, bool> visitedVertices)
        {
            throw new NotImplementedException();
        }

        public static void BreadthFirstTraverse(Vertex startVertex, IDictionary<Vertex, bool> visitedVertices, Action<string> outputProc)
        {

        }

        public static Vertex BreadthFirstSearch(Vertex startVertex, string searchValue, IDictionary<Vertex, bool> visitedVertices)
        {
            throw new NotImplementedException();
        }
    }
}
