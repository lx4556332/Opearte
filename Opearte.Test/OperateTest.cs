using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Web;

namespace Opearte.Test
{
    [TestClass]
    public class OperateTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            var  result=  SimpleFactory.GetOperateResult(1, 2, "+");
            double tvault = 3;
            Assert.AreEqual( result, tvault);
        }
    }
}