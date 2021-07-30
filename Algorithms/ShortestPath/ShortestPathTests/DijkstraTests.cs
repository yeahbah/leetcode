using System;
using Xunit;
using ShortestPath;

namespace ShortestPathTests
{
    public class DijkstraTests
    {
        [Fact]
        public void FindCheapestRouteTest()
        {
            var atlanta = new CityFlight("Atlanta");
            var boston = new CityFlight("Boston");
            var chicago = new CityFlight("Chicago");
            var denver = new CityFlight("Denver");
            var elpaso = new CityFlight("El Paso");

            atlanta.AddFlightRoute(boston, 100);
            atlanta.AddFlightRoute(denver, 160);
            boston.AddFlightRoute(chicago, 120);
            boston.AddFlightRoute(denver, 180);
            chicago.AddFlightRoute(elpaso, 80);
            denver.AddFlightRoute(elpaso, 140);
            denver.AddFlightRoute(chicago, 40);
            elpaso.AddFlightRoute(boston, 100);

            var algo = new DijkstraAlgorithm();
            var (path, cost) = algo.FindCheapestPath(atlanta, elpaso);

            // path: Atlanta -> Denver -> Chicago -> El Paso
            Assert.Equal(path[0], atlanta.CityName);
            Assert.Equal(path[1], denver.CityName);
            Assert.Equal(path[2], chicago.CityName);
            Assert.Equal(path[3], elpaso.CityName);
            Assert.Equal(280, cost);

            // no available route
            (path, cost) = algo.FindCheapestPath(chicago, atlanta);
            var expected = 1;
            Assert.Equal(path.Length, expected);
            Assert.Equal(0, cost);

            (path, cost) = algo.FindCheapestPath(boston, chicago);
            // expected: Boston -> Chicago
            Assert.Equal(path[0], boston.CityName);
            Assert.Equal(path[1], chicago.CityName);

            elpaso.AddFlightRoute(chicago, 50);
            chicago.AddFlightRoute(atlanta, 75);
            (path, cost) = algo.FindCheapestPath(denver, boston);
            // expected: Denver -> Chicago -> Atlanta -> Boston
            Assert.Equal(4, path.Length);
            Assert.Equal(denver.CityName, path[0]);
            Assert.Equal(chicago.CityName, path[1]);
            Assert.Equal(atlanta.CityName, path[2]);
            Assert.Equal(boston.CityName, path[3]);
            Assert.Equal(215, cost);
        }
    }
}
