using System;

namespace software_design_insights.ValueObject
{
    public abstract record UnitOfMeasure;

    public record Kilometers : UnitOfMeasure;

    public record Miles: UnitOfMeasure;

    public record Distance(UnitOfMeasure UnitOfMeasure, decimal Value)
    {
        public Distance ToMiles()
        {
            throw new NotImplementedException();
        }

        public Distance ToKilometers()
        {
            throw new NotImplementedException();
        }
    }
}
