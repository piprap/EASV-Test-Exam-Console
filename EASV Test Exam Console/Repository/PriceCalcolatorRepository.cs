using EASV_Test_Exam_Console.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EASV_Test_Exam_Console.Repository
{

    public class PriceCalcolatorRepository : IPriceCalcolator
    {
        IEnumerable<PriceCalculator> prices;
        public PriceCalcolatorRepository()
        {
            PriceCalculator price = new PriceCalculator();
            Cleaning clean1 = new Cleaning(200,true,false,false);
            Cleaning clean2 = new Cleaning(500, false, false, false);
            prices = new List<PriceCalculator>()
                {
              new PriceCalculator(price.CalculateCleaningPrice(clean1)),
               new PriceCalculator(price.CalculateCleaningPrice(clean2))

                 };
        }

        IEnumerable<PriceCalculator> IPriceCalcolator.GetCalculators()
           {
            return prices;
           }
    }
}

