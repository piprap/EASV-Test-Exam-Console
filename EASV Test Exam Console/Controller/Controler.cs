using EASV_Test_Exam_Console.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASV_Test_Exam_Console.Controller
{
    public class Controler
    {
        private readonly ICleaning _cleaning;
        public Controler(ICleaning repository)
        {
            _cleaning = repository;
        }
        public List<int> GetPricesFromDataSource()
        {
            List<int> results = new();
           
            IEnumerable<Cleaning> cleanings = _cleaning.GetCalculators();


            PriceCalculator priceCalculator = new PriceCalculator(); 
            foreach (var clean in cleanings)
            {
                results.Add(item: priceCalculator.CalculateCleaningPrice(clean));
            }
            return results;
        }
    }
}
