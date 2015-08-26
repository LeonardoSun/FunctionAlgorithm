using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FuncAlg;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestUnknownNumber
    {
        [TestMethod]
        public void TestMultiplyConst()
        {
            UnknownNumber x = new UnknownNumber("x");
            var r = x * 5;
            Console.WriteLine("name:{0}", r.name);

            UnknownNumber y = new UnknownNumber(5, "y");
            r = y * 7;
            Console.WriteLine("name:{0}", r.name);
        }

        [TestMethod]
        public void TestDifferentVarMultiply()
        {
            UnknownNumber u1 = new UnknownNumber("x");
            UnknownNumber y1 = new UnknownNumber(3, "y");
            var r = u1 * y1;
            Console.WriteLine("name:{0}", r.name);
        }
    }
}
