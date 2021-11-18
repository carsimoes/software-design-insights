using Xunit;

namespace ValueObject
{
    public record Currency(string Symbol)
    {
        public static Currency CAD => new Currency(Symbol: "CAD");
        public static Currency USD => new Currency(Symbol: "USD");
    }

    public record Money(Currency Currency, decimal Amount);

    public class MoneyTests
    {
        //[Fact]
        //public void Test()
        //{
        //    var money1 = new Money(Currency.CAD, Amount: 100);
        //    var money2 = new Money(Currency.CAD, Amount: 100);

        //    Assert.Equal(expected: money1, actual: money2);
        //}
    }
}
