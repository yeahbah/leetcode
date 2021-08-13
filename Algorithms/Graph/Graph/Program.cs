using System;
using System.Collections.Generic;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Vertex("a");
            var b = new Vertex("b");
            var c = new Vertex("c");
            var d = new Vertex("d");
            var e = new Vertex("e");
            var f = new Vertex("f");

            a.AdjacentVertexes.Add(b);
            a.AdjacentVertexes.Add(c);
            b.AdjacentVertexes.Add(d);
            b.AdjacentVertexes.Add(e);
            c.AdjacentVertexes.Add(f);
            c.AdjacentVertexes.Add(e);

            var visitedVertices = new Dictionary<Vertex, bool>();
            //Vertex.DepthFirstTraverse(a, visitedVertices, v => Console.WriteLine(v.Value));
            Vertex.BreadthFirstTraverse(a, v => Console.WriteLine(v.Value));
        }
    }
}
