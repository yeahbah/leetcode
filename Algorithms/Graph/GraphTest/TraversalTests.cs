using System;
using Xunit;
using Graph;
using System.Collections.Generic;

namespace GraphTest
{
    public class UnitTest1
    {
        [Fact]
        public void DepthFirstTest()
        {
            var a = new Vertex("a");
            var b = new Vertex("b");
            var c = new Vertex("c");
            var d = new Vertex("d");
            var e = new Vertex("e");
            var f = new Vertex("f");

            // a -------- b
            //   \        |
            //    \  f    |
            //     \/     |
            //      c --- e
            //       \
            //        d

            a.AdjacentVertexes.Add(b);
            a.AdjacentVertexes.Add(c);
            b.AdjacentVertexes.Add(d);
            b.AdjacentVertexes.Add(e);
            c.AdjacentVertexes.Add(f);
            c.AdjacentVertexes.Add(e);

            var actual = "";
            var visitedVertices = new Dictionary<Vertex, bool>();
            Vertex.DepthFirstTraverse(a, visitedVertices, vertex => actual += vertex.Value);

            var expected = "abdecf";
            Assert.True(expected == actual);
        }

        [Fact]
        public void BreadthFirstTest()
        {
            var a = new Vertex("a");
            var b = new Vertex("b");
            var c = new Vertex("c");
            var d = new Vertex("d");
            var e = new Vertex("e");
            var f = new Vertex("f");

            // a -------- b
            //   \        |
            //    \  f    |
            //     \/     |
            //      c --- e
            //       \
            //        d

            a.AdjacentVertexes.Add(b);
            a.AdjacentVertexes.Add(c);
            b.AdjacentVertexes.Add(d);
            b.AdjacentVertexes.Add(e);
            c.AdjacentVertexes.Add(f);
            c.AdjacentVertexes.Add(e);

            var actual = "";
            var visitedVertices = new Dictionary<Vertex, bool>();
            Vertex.BreadthFirstTraverse(a, vertex => actual += vertex.Value);

            var expected = "abcdef";
            Assert.True(expected == actual);
        }
    }
}
