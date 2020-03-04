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
                //readFromFile read = new readFromFile();
                var test = "wsx|edc|rfv|zxc|asd|qwe";
                writeFile(test, test);

            }
        }
    }
}