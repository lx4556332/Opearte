using System;
using System.Collections.Generic;
using System.Web;

namespace Opearte
{
    /// <summary>
    /// 除法
    /// </summary>
    public class DivsionOperate : OperateClass
    {
        public override double GetOperateResult()
        {
            double result = 0;
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0！");
            }

            result = NumberA / NumberB;
            return result;
        }
    }
}