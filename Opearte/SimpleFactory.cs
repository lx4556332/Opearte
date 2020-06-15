using System;
using System.Collections.Generic;
using System.Web;

namespace Opearte
{
    public class SimpleFactory
    {
        public static OperateClass GetOperate(string operate)
        {
            OperateClass oper = null;
            switch (operate)
            {
                case "+":
                    oper = new AdditionOperate();
                    break;
                case "-":
                    oper = new SubtractionOperate();
                    break;
                case "*":
                    oper = new MultiplicationOperate();
                    break;
                case "/":
                    oper = new DivsionOperate();
                    break;
            }
            return oper;
        }

        public static double GetOperateResult(double numberA,double numberB,string operate)
        {
            OperateClass oper = SimpleFactory.GetOperate(operate);
            oper.NumberA = numberA;
            oper.NumberB = numberB;
            return oper.GetOperateResult();
        }
    }
}