using Microsoft.VisualStudio.TestTools.UnitTesting;

using Xunit;

namespace DrinkWater.MainServices.Tests
{
    [TestClass()]
    public class ValidationLiquidTests
    {
        [Theory]
        [InlineData("Juice", "20", true)]
        [InlineData("Juice", "500", true)]
        [InlineData("Juice", "1000", true)]
        [InlineData("Juice", "80000", false)]
        [InlineData("Juice", "-80000", false)]

        public void IsValidAmountTest(string name, string amount, bool isValid)
        {
            ValidationLiquid liquid = new ValidationLiquid(name, amount);

            var result = liquid.IsValidAmount(amount);

            Xunit.Assert.Equal(isValid, result);

        }
    }
}