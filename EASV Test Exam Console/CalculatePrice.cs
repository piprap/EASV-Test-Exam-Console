using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASV_Test_Exam_Console
{
    public class CalculatePrice
    {

        public int GetPrice(int area, bool IsDeluxe, bool IsDoubleWash, bool IsImpreg)
        {

          int TotalPrice = 500; //starting fee

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


            if (IsDeluxe || IsDoubleWash && IsImpreg)
            {
                TotalPrice = (int)Math.Round(TotalPrice * 1.6);
            }else if( IsDoubleWash )
            {
                TotalPrice = (int)Math.Round(TotalPrice * 1.5);
            }else if(IsImpreg)
            {
                TotalPrice = (int)Math.Round(TotalPrice * 1.2);
            }

            Console.WriteLine(TotalPrice);
            return TotalPrice;
        }
    }
}
