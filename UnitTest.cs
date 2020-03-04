using forex.Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forex
{
    class UnitTest
    {
        [TestClass]

        public class UnitTests: engine
        {
            [TestMethod]
            public void runtests()
            {
                var test = "wsx|edc|rfv|zxc|asd|qwe";
                writeFile(test, test);

            }
        }
    }
}