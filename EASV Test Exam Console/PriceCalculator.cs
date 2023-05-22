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
            int area = cleaning.area;
            if (area <= 100)
            {
                TotalPrice += area * 20;
            }
            else if (area <= 200)
            {
                TotalPrice += (area - 100) * 15;
                TotalPrice += 2000;
            }
            else if (area <= 500)
            {
                TotalPrice += (area - 200) * 10; // the + was missing but tests was used and located because of testcases 9, 10 and 11
                TotalPrice += 3500;
            }
            if (cleaning.IsDeluxe || cleaning.IsDoubleWash && cleaning.IsImpreg)
            {
                TotalPrice = (int)Math.Round(TotalPrice * 1.6);
            }
            else if (cleaning.IsDoubleWash)
            {
                TotalPrice = (int)Math.Round(TotalPrice * 1.5);
            }
            else if (cleaning.IsImpreg)
            {
                TotalPrice = (int)Math.Round(TotalPrice * 1.2);
            }
            return TotalPrice;
        }
    }
}
