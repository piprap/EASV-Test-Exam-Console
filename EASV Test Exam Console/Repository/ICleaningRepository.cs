using EASV_Test_Exam_Console.Interface;
using NPOI.SS.Formula.Functions;
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

    public class ICleaningRepository : ICleaning
    {
        IEnumerable<Cleaning> prices;
        public ICleaningRepository()
        {
            prices = new List<Cleaning>()
                {
              new Cleaning(200,true,false,false),
              new Cleaning(500,false,false,false)
                 };
        }

        IEnumerable<Cleaning> ICleaning.GetCalculators()
        {
        return prices;
        }
    }
}

