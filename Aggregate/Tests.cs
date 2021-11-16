using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace software_design_insights.Aggregate
{
    public class Tests
    {
        private readonly Shipment _shipment;

        public Tests()
        {
            var stops = new List<Stop>
            {
                new PickupStop
                {
                    StopId = 1,
                    Sequence = 1,
                },
                new PickupStop
                {
                       StopId = 2,
                    Sequence = 2,
                }
            };

            _shipment = new Shipment(stops);
        }

        [Fact]
        public void CompleteShipment()
        {
            _shipment.Arrive(1);
            _shipment.Arrive(1);
            _shipment.Arrive(2);
            _shipment.Arrive(2);
            Assert.True(_shipment.IsComplete());
        }

        [Fact]
        public void CannotPickupWithoutArriving()
        {
            //Assert.Throws<InvalidOperationException>(() => _shipment.Pickup(1), "Stop hasn't arrived yet.");
            
        }


    }
}
