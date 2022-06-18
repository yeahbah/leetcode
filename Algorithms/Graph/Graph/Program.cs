using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Graph
{
    class Program
    {
        static void Main()
        {
            var summary = BenchmarkRunner.Run<Performance>();
        }

        static void Main1(string[] args)
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
            // output:
            //a
            //b
            //d
            //e
            //c
            //f
            Console.WriteLine("Dfs: recursive");
            Vertex.DepthFirstTraverse(a, visitedVertices, v => Console.WriteLine(v.Value));
            Console.WriteLine("Dfs: iterative");
            Vertex.DepthFirstTraverseIterative(a, v => Console.WriteLine(v.Value));


            //Vertex.BreadthFirstTraverse(a, v => Console.WriteLine(v.Value));
        }
    }

    public class Performance
    {
        [Benchmark]
        public void DepthFirst_Recursive() => DepthFirstTraverse_Recursive();

        [Benchmark]
        public void DepthFirst_Iterative() => DepthFirstTraverse_Iterative();

        [Benchmark]
        public void BfsTraverse_Iterative() => BfsTraverseIterative();

        public void BfsTraverseIterative()
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
            Vertex.BreadthFirstTraverse(a, null);
        }


        public void DepthFirstTraverse_Iterative()
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
            Vertex.DepthFirstTraverseIterative(a, null);
            
        }

        public void DepthFirstTraverse_Recursive()
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
            Vertex.DepthFirstTraverse(a, visitedVertices, null);
            
        }
    }
}
