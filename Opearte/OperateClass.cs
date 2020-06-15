using System;
using System.Collections.Generic;
using System.Web;

namespace Opearte
{
    public class OperateClass
    {
        public double  NumberA { get; set; }

        public double NumberB { get; set; }

        public virtual double GetOperateResult()
        {
            double result = 0;
            return result;
        }
    }
}