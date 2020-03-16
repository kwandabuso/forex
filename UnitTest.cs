using forex.Engine;
using Microsoft.Data.Sqlite;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace forex
{
    class UnitTest
    {
        [TestClass]
        public class UnitTests
        {
            [TestMethod]
            private static void CreateConnection()
                {

                    SQLiteConnection sqlite_conn;
                    // Create a new database connection:
                    sqlite_conn = new SQLiteConnection("Data Source=C:\\kwanda\\sqlite\\SQLiteStudio\\forex.sdb; Version = 3; New = True; Compress = True; ");
                 // Open the connection:
                 try
                            {
                                sqlite_conn.Open();
                            }
                            catch (Exception ex)
                            {

                            }
                            //return sqlite_conn;
                        }


            }
        }
    }
