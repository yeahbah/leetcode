using System;
using System.Collections.Generic;

namespace ShortestPath
{
    public record CityFlight
    {
        public CityFlight(string cityName)
        {
            CityName = cityName;
        }

        private readonly Dictionary<CityFlight, decimal> _flightRoutes = new();
        public IDictionary<CityFlight, decimal> FlightRoutes => _flightRoutes;

        public string CityName { get; init; }

        public void AddFlightRoute(CityFlight cityFlight, decimal value)
        {
            this._flightRoutes[cityFlight] = value;
        }
    }
}
