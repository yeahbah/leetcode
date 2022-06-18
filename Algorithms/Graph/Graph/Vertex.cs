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

        public static void DepthFirstTraverseIterative(Vertex startVertex, Action<Vertex> outputProc)
        {
            var visitedVertex = new Dictionary<Vertex, bool>();
                      
            outputProc?.Invoke(startVertex);
            visitedVertex[startVertex] = true;

            foreach (var v in startVertex.AdjacentVertexes)
            {
                if (visitedVertex.ContainsKey(v)) continue;

                var queue = new Queue<Vertex>();
                queue.Enqueue(v);
                while (queue.Count > 0)
                {
                    

                    var x = queue.Dequeue();
                    outputProc?.Invoke(x);
                    visitedVertex[x] = true;

                    foreach(var y in x.AdjacentVertexes)
                    {
                       queue.Enqueue(y);
                    }
                }

              
            }            
        }
        
        public static void BreadthFirstTraverse(Vertex startVertex, Action<Vertex> outputProc)
        {
            var queue = new Queue<Vertex>();
            var visitedVertices = new Dictionary<Vertex, bool>();
            queue.Enqueue(startVertex);
            visitedVertices[startVertex] = true;

            while (queue.Count > 0)
            {
                var currentVertex = queue.Dequeue();
                outputProc?.Invoke(currentVertex);
                foreach (var adjacentVertex in currentVertex.AdjacentVertexes)
                {
                    if (visitedVertices.ContainsKey(adjacentVertex)) 
                        continue;

                    visitedVertices[adjacentVertex] = true;
                    queue.Enqueue(adjacentVertex);                    
                }
            }           
        }
    }
}
