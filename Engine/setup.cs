using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forex.Engine
{
    public class setup
    {
        public string getDBPath(string Env)
        {
            string newPath = "Stg";
            var path = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

            string directory = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString();

            if(Env.Equals("Live"))
            {
                newPath = directory + @"\DBase\Forex_Live.sdb";
            }
            else
            {
                newPath = directory + @"\DBase\Forex.sdb";
            }
            


            return newPath;
        }
    }
}
