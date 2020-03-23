using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forex.Engine
{
    class GlobalVariables
    {
        public static string TradesPath { get; set; }
        public static string TradesDecisions { get; set; }
        public static string DataBase { get; set; }

    }
}
