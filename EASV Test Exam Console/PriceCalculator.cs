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
                TotalPrice = (area - 200) * 10;
                TotalPrice += 3500;
            }

            return TotalPrice;
        }
    }
}
