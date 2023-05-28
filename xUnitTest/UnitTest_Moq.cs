using EASV_Test_Exam_Console;
using EASV_Test_Exam_Console.Controller;
using EASV_Test_Exam_Console.Interface;
using Moq;
using NPOI.SS.Formula.Functions;
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
        private Controler controller;
        public UnitTest_Moq()
        {
            List<Cleaning> Cleanings = new List<Cleaning>()
            {
                new Cleaning(200,true,false,false),
                new Cleaning(500,false,false,false),
             };
            Mock<ICleaning> repository = new Mock<ICleaning>();
            repository.Setup(p => p.GetCalculators()).Returns(Cleanings);
            controller = new Controler(repository.Object);
        }
        [Fact]
        public void GetCalculators_ReturnsListWithCorrectNumberOfCleaninges()
        {
            //Arrange
         
            //Act
            var result = controller.GetPricesFromDataSource();
            var noOfPrices = result.Count;
           
            //Assert
            Assert.Equal(2, noOfPrices);

        }
        [Fact]
        public void GetCalculators_ReturnsListWithCorrectValuesOfCleaninges()
        {
            //Arrange
            //Act
            var Expected = controller.GetPricesFromDataSource();
           int[] Actual = {6400,7000};

            //Assert
            Assert.Equal(Expected, Actual);

        }
    }
}
