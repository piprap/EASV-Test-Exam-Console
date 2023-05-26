using EASV_Test_Exam_Console;
using EASV_Test_Exam_Console.Interface;
using Moq;
using System.Diagnostics;

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
        [InlineData(100, false, false, false, 2500)]
        public void GetPrice_Data_Driven_Test_Return_Int(int area, bool IsDeluxe, bool IsDoubleWash, bool IsImpreg, int acceptedResult)
        {
            Cleaning cleaning = new Cleaning(area, IsDeluxe, IsDoubleWash, IsImpreg);
            PriceCalculator priceCalculator = new PriceCalculator();
            int price = priceCalculator.CalculateCleaningPrice(cleaning);

            //CalculatePrice calc = new CalculatePrice();
            //int price = calc.GetPrice(area, IsDeluxe, IsDoubleWash, IsImpreg);

            Assert.Equal(acceptedResult, price);

        }


        [Fact]
        public void PriceCalculatorCalculateCleaningPrice_AreaIsMinusOne_ExpectedOutcomeError()
        {
            //Arrange
            PriceCalculator priceCalculator = new PriceCalculator();
            Cleaning cleaning = new(-1);
            //Act
            Action act = () => priceCalculator.CalculateCleaningPrice(cleaning);

            //Assert
            Assert.Throws<ArgumentException>(act);

        }
        [Fact]
        public void PriceCalculatorCalculateCleaningPrice_AreaIs501_ExpectedOutcomeError()
        {
            //Arrange
            PriceCalculator priceCalculator = new PriceCalculator();
            Cleaning cleaning = new(501);
            //Act
            Action act = () => priceCalculator.CalculateCleaningPrice(cleaning);

            //Assert
            Assert.Throws<ArgumentException>(act);

        }
        [Fact]
        public void PriceCalculatorCalculateCleaningPrice_AreaIsOne_ExpectedOutcome520()
        {
            //Arrange
            int price = 0;
            PriceCalculator priceCalculator = new PriceCalculator();
            Cleaning cleaning = new (1);
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
        [Fact]
        public void PriceCalculatorCalculateCleaningPrice_AreaIs200WithImpreg_ExpectedOutcome4800()
        {
            //Arrange
            int price = 0;
            PriceCalculator priceCalculator = new PriceCalculator();
            Cleaning cleaning = new Cleaning(200, false, false, true);
            //Act
            price = priceCalculator.CalculateCleaningPrice(cleaning);

            //Assert
            Assert.Equal(4800, price);

        }
        [Fact]
        public void PriceCalculatorCalculateCleaningPrice_AreaIs200WithDeluxe_ExpectedOutcome6400()
        {
            //Arrange
            int price = 0;
            PriceCalculator priceCalculator = new PriceCalculator();
            Cleaning cleaning = new Cleaning(200, true, false, false);
            //Act
            price = priceCalculator.CalculateCleaningPrice(cleaning);

            //Assert
            Assert.Equal(6400, price);

        }
        [Fact]
        public void Cleaning_CleaningWithAllTrue_ExpectedIsDoubleWashFalse()
        {
            //Arrange
            //Act
            Cleaning cleaning = new Cleaning(200, true, true, true);

            //Assert
            Assert.False(cleaning.IsDoubleWash);
            
        }
        [Fact]
        public void Cleaning_CleaningWithAllTrue_ExpectedIsImpredFalse()
        {
            //Arrange
            //Act
            Cleaning cleaning = new Cleaning(200, true, true, true);

            //Assert
            Assert.False( cleaning.IsImpreg);

        }
       
    }
}