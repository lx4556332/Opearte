using System;
using System.Collections.Generic;
using System.Web;

namespace Opearte
{
    public class AdditionOperate:OperateClass
    {
        /// <summary>
        /// 加法
        /// </summary>
        /// <returns></returns>
        public override double GetOperateResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
}