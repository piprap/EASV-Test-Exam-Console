using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASV_Test_Exam_Console
{
    public class PriceCalculator
    {
        public int CalculateCleaningPrice(Cleaning cleaning)
        {
            if (cleaning.area<0) throw new ArgumentException("Area cannot be negative");
            if (cleaning.area>500) throw new ArgumentException("For Areas Highter than 500 Call for price");
           
            int TotalPrice = 500; //starting fee
            
            TotalPrice += CalculateAreaPrice(cleaning.area);
            TotalPrice = (int)Math.Round(TotalPrice * CalculateMultiplier(cleaning));

            return TotalPrice;
        }
        private int CalculateAreaPrice(int area)
        {
            int AreaPrice = 0;
            if (area <= 100)
            {
                AreaPrice += area * 20;
            }
            else if (area <= 200)
            {
                AreaPrice += (area - 100) * 15;
                AreaPrice += 2000;
            }
            else if (area <= 500)
            {
                AreaPrice += (area - 200) * 10; // the + was missing but tests was used and located because of testcases 9, 10 and 11
                AreaPrice += 3500;
            }
            return AreaPrice;
        }
        private double CalculateMultiplier(Cleaning cleaning)
        {
            if (cleaning.IsDeluxe || cleaning.IsDoubleWash && cleaning.IsImpreg)
            {
                return 1.6;
            }
            else if (cleaning.IsDoubleWash)
            {
                return 1.5;
            }
            else if (cleaning.IsImpreg)
            {
                return 1.2;
            }
            return 1;
        }

  
    }
}
