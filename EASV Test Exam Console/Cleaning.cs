using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASV_Test_Exam_Console
{
    public class Cleaning
    {
        public int area { get; set; }
        public bool IsDeluxe { get; set; } = false;
        public bool IsDoubleWash { get; set; } = false;
        public bool IsImpreg { get; set; } = false;


        
        public Cleaning(int area, bool IsDeluxe, bool IsDoubleWash,bool IsImpreg) 
        {
            this.area = area;
            if(IsDeluxe)
            {
                this.IsDeluxe = IsDeluxe;
                this.IsDoubleWash = false;
                this.IsImpreg = false;
            }
            else
            {
                this.IsDoubleWash = IsDoubleWash;
                this.IsImpreg = IsImpreg;
            }
        }
        public Cleaning(int area)
        {
            this.area=area;
        }
        public override string ToString()
        {
            return "[Area: "+this.area+" IsDeluxe: "+this.IsDeluxe+" IsDoubleWash: "+this.IsDoubleWash+" IsImpreg: "+this.IsImpreg+"]"; 
        }

    }
}
