﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forex.Engine
{
    public class engine
    {

        public engine()
        {

        }

        public static SQLiteConnection CreateConnection()
        {
            var connectionString="";
            SQLiteConnection sqlite_conn;

            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source = "+GlobalVariables.DBPath+"; Version = 3; UseUTF16Encoding = True;");
           

            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }

        public List<String> ReadFile(string path, string status)
        {
            try
            {
                // Read file to list
                var lst = new List<string>();

               var trades = new List<string>();

                lst = File.ReadAllLines(path).ToList();


                if(!status.Equals(""))
                {
                   return trades = lst.Where(name => name.Contains(status)).ToList();
                }
                
                  return  lst = File.ReadAllLines(path).ToList();
                
                
                //return trades;
            }
            catch (Exception e)
            {
                
                throw;
            }
        }

        public void writeFile(string path, params string []items)
        {
            //foreach(var item in items)
            //{
           
            for (int i = 0; i < items.Length; i++)
            {
                System.IO.File.AppendAllText(path, items[i] + Environment.NewLine);
                
                //var test = items[i];
                //builder.Append(items[i]);
                //builder.Append(" ");
            }
            //System.IO.File.AppendAllText(path, "\n");
            //}

        }

    }
}
