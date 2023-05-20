using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASV_Test_Exam_Console
{
    public class CalculatePrice
    {
        public CalculatePrice( int area, bool isDeluxe, bool isDoubleWash, bool isImpreg)
        {
            
            this.area = area;
            IsDeluxe = isDeluxe;
            IsDoubleWash = isDoubleWash;
            IsImpreg = isImpreg;
        }

        public int Id { get; set; }
        public int area { get; set; }
        public bool IsDeluxe { get; set; } = false;
        public bool IsDoubleWash { get; set; } = false;
        public bool IsImpreg { get; set; } = false;



        public int GetPrice(CalculatePrice obj)
        {

          int TotalPrice = 500; //starting fee

            if (obj.area <= 100)
            {
                TotalPrice += obj.area * 20;
            }
            else if (obj.area <= 200)
            {
                TotalPrice += (obj.area - 100) * 15;
                TotalPrice += 2000;
            }
            else if (obj.area <= 500)
            {
                TotalPrice = (obj.area - 200) * 10;
                TotalPrice += 3500;
            }
            if (obj.IsDeluxe || obj.IsDoubleWash && obj.IsImpreg)
            {
                TotalPrice = (int)Math.Round(TotalPrice * 1.6);
            }else if( obj.IsDoubleWash )
            {
                TotalPrice = (int)Math.Round(TotalPrice * 1.5);
            }else if(obj.IsImpreg)
            {
                TotalPrice = (int)Math.Round(TotalPrice * 1.2);
            }

            Console.WriteLine(TotalPrice);
            return TotalPrice;

            //price1 = 100
            //price2 = 
            //price3 = 

            //modes: 
            //No multiplier = 000
            //Imprægnering  = 100
            //DoubleVask    = 010
            //Both          = 001
        }
    }
}
