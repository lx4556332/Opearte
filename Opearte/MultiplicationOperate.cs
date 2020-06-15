using System;
using System.Collections.Generic;
using System.Web;

namespace Opearte
{
    /// <summary>
    /// 乘法
    /// </summary>
    public class MultiplicationOperate : OperateClass
    {
        public override double GetOperateResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
}