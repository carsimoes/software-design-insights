using System;

namespace software_design_insights.ValueObject
{
    public record PlaceOrderCommand(Guid CustomerId, string ProductSku, int Quantity, PlaceOrderCurrency Currenncy)
    {
        public PlaceOrderCommand(Guid customerId, string productSku)
            : this(customerId, productSku, Quantity: 1, PlaceOrderCurrency.Default)
        {
            throw new NotImplementedException();
        }

        public PlaceOrderCommand(Guid customerId, string productSku, PlaceOrderCurrency currency)
            : this(customerId, productSku, Quantity: 1, currency)
        {
            throw new NotImplementedException();
        }

        public PlaceOrderCommand(Guid customerId, string productSku, int quantity)
            : this(customerId, productSku, Quantity: 1, PlaceOrderCurrency.Default)
        {
            throw new NotImplementedException();
        }
    }

    public record PlaceOrderCurrency(string Symbol)
    {
        public static PlaceOrderCurrency Default => new(Symbol: "USD");
    }

}
