﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASV_Test_Exam_Console.Interface
{
    public interface IPriceCalcolator
    {
        IEnumerable<PriceCalculator> GetCalculators();
    }
}
