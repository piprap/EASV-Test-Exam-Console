using EASV_Test_Exam_Console;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCleaningCalculator.StepDefinitions
{
    [Binding]
    public class PriceCalculatorStepDefinitions
    {

        int _area;
        bool _isDeluxe, _IsDoubleWash, _IsImpreg;
        PriceCalculator priceCalculator = new PriceCalculator();
        Cleaning cleaning;


        [Given(@"I have entered an (.*)")]
        public void GivenIHaveEnteredAn(int area)
        {
            _area = area;
        }
        [Given(@"I have also decided if IsDeluxe '([^']*)'")]
        public void GivenIHaveAlsoDecidedIfIsDeluxe(string @false)
        {
            _isDeluxe = Boolean.Parse(@false);
        }

        [Given(@"I have also decided if IsDoubleWash '([^']*)'")]
        public void GivenIHaveAlsoDecidedIfIsDoubleWash(string @false)
        {
            _IsDoubleWash = Boolean.Parse(@false);
        }

        [Given(@"I have also decided if IsImpreg '([^']*)'")]
        public void GivenIHaveAlsoDecidedIfIsImpreg(string @false)
        {
            _IsImpreg = Boolean.Parse(@false);
        }

        [When(@"I press button Calculate price")]
        public void WhenIPressButtonCalculatePrice()
        {
            cleaning = new Cleaning(_area,_isDeluxe,_IsDoubleWash,_IsImpreg); 
        }

        [Then(@"The result should be (.*)")]
        public void ThenTheResultShouldBe(int price)
        {
            int calculatedPrice;
            try
            {
                calculatedPrice = priceCalculator.CalculateCleaningPrice(cleaning);
            }
            catch (Exception)
            {
                calculatedPrice= -1;
            }
            Assert.Equal(price, calculatedPrice);
        }
    }

}
