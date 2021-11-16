using System;
using System.Collections.Generic;
using System.Linq;

namespace software_design_insights.Aggregate
{
    public class Shipment
    {
        private readonly IList<Stop> _stops;

        public Shipment(IList<Stop> stops)
        {
            _stops = stops;
        }

        public bool IsComplete()
        {
            return _stops.All(x => x.Status == StopStatus.Departed);
        }

        public void Arrive(int stopId)
        {
            var currentStop = _stops.SingleOrDefault(x => x.StopId == stopId);
            if (currentStop == null)
            {
                throw new InvalidOperationException(message: "Stop doesn't exist.");
            }

            var previousStopsAreNotDeparted = _stops.Any(x => x.Sequence < currentStop.Sequence && x.Status != StopStatus.Departed);
            if (previousStopsAreNotDeparted)
            {
                throw new InvalidOperationException(message: "Previous stops have not departed.");
            }

            currentStop.Arrive();
        }

        public void Pickup(int stopId)
        {
            throw new NotImplementedException();
        }

        public void Deliver(int stopId)
        {
            var currentStop = _stops.SingleOrDefault(x => x.StopId == stopId);
            if (currentStop == null)
            {
                throw new InvalidOperationException(message: "Stop doesn't exist.");
            }

            if (currentStop is DeliveryStop == false)
            {
                throw new InvalidOperationException(message: "Stops is not a delivery.");
            }

            currentStop.Depart();
        }
    }
}
