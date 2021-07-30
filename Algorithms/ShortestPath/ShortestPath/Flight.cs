using System;
using System.Collections.Generic;

namespace ShortestPath
{

    public record CityFlight
    {
        private readonly string _value;
        public CityFlight(string cityName)
        {
            _value = cityName;
        }
        public string Value => _value;

        private readonly Dictionary<CityFlight, decimal> _flightRoutes = new();
        public IDictionary<CityFlight, decimal> FlightRoutes => _flightRoutes;

        public string CityName { get => _value; }

        public void AddFlightRoute(CityFlight cityFlight, decimal value)
        {
            this._flightRoutes[cityFlight] = value;
        }
    }
}
