using System;
using System.Collections.Generic;
using System.Web;

namespace Opearte
{
    /// <summary>
    /// 减法
    /// </summary>
    public class SubtractionOperate:OperateClass
    {
        public override double GetOperateResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
}