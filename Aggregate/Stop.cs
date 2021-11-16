using System;

namespace software_design_insights.Aggregate
{
    public abstract class Stop
    {
        public int StopId { get; set; }

        public StopStatus Status { get; set; }

        public int Sequence { get; set; }

        public void Arrive()
        {
            if (Status != StopStatus.InTransit)
            {
                throw new InvalidOperationException(message:"Stop has already arrived.");
            }

            Status = StopStatus.Arrived;
        }

        public void Depart()
        {
            if(Status == StopStatus.Departed)
            {
                throw new InvalidOperationException(message:"Stop has already departed.");
            }

            if (Status == StopStatus.InTransit)
            {
                throw new InvalidOperationException(message: "Stop hasn't arrived yet.");
            }

            Status = StopStatus.Departed;
        }
    }

    public class PickupStop : Stop { }

    public class DeliveryStop : Stop { }

    public enum StopStatus
    {
        InTransit,
        Arrived,
        Departed
    }
}
