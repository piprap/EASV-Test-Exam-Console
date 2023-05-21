using EASV_Test_Exam_Console;

namespace xUnitTest
{
    public class UnitTest1
    {
        [Fact]




        public void Test1() => Assert.Equal(1, 1);


        [Theory]
        [InlineData(0, false, false, false, 500)] //500
        [InlineData(1, false, false, false, 520)] //520
        [InlineData(99, false, false, false, 2480)]
        [InlineData(99, false, false, false, 5555)]
        public void GetPrice_Data_Driven_Test_Return_Int(int area, bool IsDeluxe, bool IsDoubleWash, bool IsImpreg, int acceptedResult)
        {

            CalculatePrice calc = new CalculatePrice();
            int price = calc.GetPrice(area, IsDeluxe, IsDoubleWash, IsImpreg);

            Assert.Equal(acceptedResult, price);

        }


        [Fact]
        public void PriceCalculatorCalculateCleaningPrice_AreaIsOne_ExpectedOutcome520()
        {
            //Arrange
            int price = 0;
            PriceCalculator priceCalculator = new PriceCalculator();
            Cleaning cleaning = new Cleaning(1);
            //Act
            price = priceCalculator.CalculateCleaningPrice(cleaning);

            //Assert
            Assert.Equal(520, price);

        }
        [Fact]
        public void PriceCalculatorCalculateCleaningPrice_AreaIsHundred_ExpectedOutcome2500()
        {
            //Arrange
            int price = 0;
            PriceCalculator priceCalculator = new PriceCalculator();
            Cleaning cleaning = new Cleaning(100);
            //Act
            price = priceCalculator.CalculateCleaningPrice(cleaning);

            //Assert
            Assert.Equal(2500, price);

        }

    }
}