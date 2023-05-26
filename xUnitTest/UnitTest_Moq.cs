using EASV_Test_Exam_Console;
using EASV_Test_Exam_Console.Interface;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTest
{
    public class UnitTest_Moq
    {
        private PriceCalculator controller;
        public UnitTest_Moq()
        {
            Cleaning clean = new Cleaning();
           
            List<PriceCalculator> prices = new List<PriceCalculator>()
            {
                new PriceCalculator(clean.area=200),
                new PriceCalculator(clean.area=500),
             };
            Mock<IPriceCalcolator> repository = new Mock<IPriceCalcolator>();
            repository.Setup(p => p.GetCalculators()).Returns(prices);
            controller = new PriceCalculator(repository.Object);
        }
        [Fact]
        public void GetAll_ReturnsListWithCorrectNumberOfPriceCalcolator()
        {
            //Act
            var result = controller.GetPricesFromDataSource();
            var noOfPrices = result.Count;
           
            //Assert
            Assert.Equal(2, noOfPrices);

        }
        [Fact]
        public void GetAll_ReturnsListWithCorrectValueOfPriceCalcolator()
        {
            //Act
            var Expected = controller.GetPricesFromDataSource();
           
            int[] Actual = {6400,7000};
            //Assert
            Assert.Equal(Expected, Actual);

        }
    }
}
