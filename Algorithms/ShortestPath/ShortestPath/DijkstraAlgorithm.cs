using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortestPath
{
    public class DijkstraAlgorithm
    {
        public DijkstraAlgorithm()
        {

        }

        public ValueTuple<string[], decimal> FindCheapestPath(CityFlight startingCity, CityFlight finalDestination)
        {
            CityFlight currentCity = startingCity;
            var cheapestPriceTable = new Dictionary<string, decimal>
            {
                [startingCity.CityName] = 0
            };
            var cheapestPreviousCityStopOver = new Dictionary<string, string>();

            var visitedCities = new Dictionary<string, bool>();
            var unvisitedCities = new List<CityFlight>();
            while (currentCity != null)
            {
                visitedCities[currentCity.CityName] = true;
                if (unvisitedCities.Contains(currentCity))
                {
                    unvisitedCities.Remove(currentCity);
                }

                // check each adjacent vertexes
                // add to unvisited list if not yet visited
                foreach (var flightRouteKeyPair in currentCity.FlightRoutes)
                {
                    var adjacentCity = flightRouteKeyPair.Key;
                    var flightCostThroughCity = flightRouteKeyPair.Value;
                    if (!visitedCities.ContainsKey(adjacentCity.CityName))
                    {
                        unvisitedCities.Add(adjacentCity);
                    }
                    
                    if (cheapestPriceTable.ContainsKey(currentCity.CityName))
                        flightCostThroughCity += cheapestPriceTable[currentCity.CityName];

                    if (!cheapestPriceTable.ContainsKey(adjacentCity.CityName) ||
                        (cheapestPriceTable.TryGetValue(adjacentCity.CityName, out var cost) && flightCostThroughCity < cost))
                    {
                        // update cheapest price table
                        cheapestPriceTable[adjacentCity.CityName] = flightCostThroughCity;
                        // key: destination
                        // value: source
                        cheapestPreviousCityStopOver[adjacentCity.CityName] = currentCity.CityName;
                    }
                    else
                    {
                        unvisitedCities.Remove(adjacentCity);
                    }
                }


                currentCity = unvisitedCities
                    .Select(x => new
                    {
                        City = x,
                        x.CityName,
                        Price = cheapestPriceTable[x.CityName]
                    })
                    .OrderBy(x => x.Price)
                    .FirstOrDefault()?.City;
                    
            }

            var currentCityName = finalDestination.CityName;
            var result = new List<string>();
            while (currentCityName != startingCity.CityName && cheapestPreviousCityStopOver.TryGetValue(currentCityName, out var sourceCity))
            {
                result.Add(currentCityName);
                currentCityName = sourceCity;
            }
            result.Add(startingCity.CityName);
            result.Reverse();
            cheapestPriceTable.TryGetValue(finalDestination.CityName, out var flightCost);
            return (result.ToArray(), flightCost);
        }
    }
}
