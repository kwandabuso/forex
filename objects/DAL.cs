using forex.Engine;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forex.objects
{
    public class DAL : engine
    {
        public static SQLiteConnection conn { get; set; }
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private static DataSet ds = new DataSet();
        private static DataTable dt = new DataTable();
        NpgsqlCommand cmd = new NpgsqlCommand();

        public static void InsertData(string decision, string indies, string notes, string open)
        {
            try
            {
                conn = CreateConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO PlaceTrades(Decision,Notes,Status,DateOpened,Indicies) VALUES('" + decision + "','" + notes + "','" + open + "','" + DateTime.Now + "','" + indies + "');";
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        public DataTable ReadData()
        {
            try
            {
                conn = CreateConnection();


                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();

                string CommandText = "SELECT Id AS [Trade ID], Decision AS [Trade Decision],Notes,Status AS[Trade Status], reasonClosed AS [trade Closed Reason], Amount,DateOpened as[Date and time Of Trades] FROM PlaceTrades";

                DB = new SQLiteDataAdapter(CommandText, conn);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                conn.Close();

                return DT;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return DT;
        }

        public DataTable ReadDataSome(string searchBy)
        {
            try
            {
                conn = CreateConnection();


                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();

                string dta = searchBy.ToUpper();

                string CommandText = "SELECT Decision AS [Trade Decision],Notes,Status AS[Trade Status], FROM PlaceTrades where Decision = '" + searchBy.ToUpper() + "';";

                DB = new SQLiteDataAdapter(CommandText, conn);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];

                return DT;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return DT;

        }

        public DataTable ReadStatusData(string searchBy)
        {
            try
            {
                conn = CreateConnection();


                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();

                string dta = searchBy.ToUpper();

                string CommandText = "SELECT Decision,Notes,Status, reasonClosed, amount,DateTime FROM PlaceTrades where Status = '" + searchBy.ToUpper() + "';";

                DB = new SQLiteDataAdapter(CommandText, conn);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];

                return DT;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return DT;
        }

        public DataTable ReadDecisionData()
        {
            try
            {
                conn = CreateConnection();


                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();

                string CommandText = "SELECT Decision FROM Decisions";

                DB = new SQLiteDataAdapter(CommandText, conn);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];

                return DT;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return DT;
        }

        public DataTable ReadTradedsDataOnSelectedText(string selectedText)
        {
            try
            {
                conn = CreateConnection();
                string CommandText = "";

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                if (selectedText.ToUpper().Equals("ALL"))
                {
                    CommandText = "SELECT Decision,Notes,Status,DateTime FROM PlaceTrades";
                }
                else
                {
                    CommandText = "SELECT Decision,Notes,Status,DateTime FROM PlaceTrades where Decision='" + selectedText + "'";
                }


                DB = new SQLiteDataAdapter(CommandText, conn);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];

                return DT;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return DT;

        }

        public void udpateRecords(string Id, string status, string prof, string amount)
        {
            try
            {
                conn = CreateConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "UPDATE PlaceTrades SET Status = '" + status + "',reasonClosed = '" + prof + "', Amount = '" + amount + "' , dateTimeClosed = '" + DateTime.Now + "' WHERE Id = '" + Id + "';";
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public DataTable ReadAllData()
        {

            try
            {
                var con = CreatePostgresConnection();


                var sql = "SELECT \"TradeId\",\"Decision\", \"Notes\", \"Indicies\",  \"Status\",\"reasonClosed\", \"Amount\"," +
                    " \"PostMotemNotes\", \"DateTimeAdded\", \"dateTimeClosed\" FROM \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\"ORDER BY  \"DateTimeAdded\" desc;";

                //var sql = "SELECT * FROM \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\" c";

                NpgsqlCommand MyCommand = con.CreateCommand();

                MyCommand.CommandText = sql;

                NpgsqlDataAdapter myDataAdapter = new NpgsqlDataAdapter();

                myDataAdapter.SelectCommand = MyCommand;


                DataSet myDataSet = new DataSet();
                int recexist = myDataAdapter.Fill(myDataSet);

                dt = myDataSet.Tables[0];
                return dt;
            }

            catch (Exception ex)
            {

            }
            return dt;
        }

        public DataTable ReadAllDataOnSelectedDate(string startDate, string endDate)
        {

            try
            {
                var con = CreatePostgresConnection();


                var sql = "SELECT \"TradeId\",\"Decision\", \"Notes\", \"Indicies\",  \"Status\",\"reasonClosed\", \"Amount\"," +
                    " \"PostMotemNotes\", \"DateTimeAdded\", \"dateTimeClosed\" FROM \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\" where \"DateTimeAdded\" between '"+ startDate + "' AND '"+endDate+"' order by \"DateTimeAdded\" asc";

                //var sql = "SELECT * FROM \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\" c";

                NpgsqlCommand MyCommand = con.CreateCommand();

                MyCommand.CommandText = sql;

                NpgsqlDataAdapter myDataAdapter = new NpgsqlDataAdapter();

                myDataAdapter.SelectCommand = MyCommand;

                DataSet myDataSet = new DataSet();
                int recexist = myDataAdapter.Fill(myDataSet);

                dt = myDataSet.Tables[0];
                return dt;
            }

            catch (Exception ex)
            {

            }
            return dt;
        }

        public DataTable ReadDataOnSelectedText(string selectedText)
        {
            var sql = "";


            try
            {
                var con = CreatePostgresConnection();


                if (selectedText.ToUpper().Equals("BUY") || selectedText.ToUpper().Equals("SELL") || selectedText.ToUpper().Equals("WAIT"))
                {
                    sql = "SELECT \"TradeId\",\"Decision\", \"Notes\", \"Indicies\",  \"Status\",\"reasonClosed\", \"Amount\"," +
                    " \"PostMotemNotes\", \"DateTimeAdded\", \"dateTimeClosed\" FROM \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\"" +
                    "where \"Decision\" = '" + selectedText.ToUpper() + "' ;";


                    //sql = "SELECT * FROM \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\" where \"Decision\" = '" + selectedText.ToUpper() + "' ;";
                }
                else if(selectedText.ToUpper().Equals("OPEN") || selectedText.ToUpper().Equals("CLOSED"))
                {
                     sql = "SELECT \"TradeId\",\"Decision\", \"Notes\", \"Indicies\",  \"Status\",\"reasonClosed\", \"Amount\"," +
                   " \"PostMotemNotes\", \"DateTimeAdded\", \"dateTimeClosed\" FROM \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\"" +
                   "where \"Status\" = '" + selectedText.ToUpper() + "' ;";

                    //sql = "SELECT * FROM \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\" where \"Status\" = '" + selectedText.ToUpper() + "' ;";
                }
                else
                    sql = "SELECT \"TradeId\",\"Decision\", \"Notes\", \"Indicies\",  \"Status\",\"reasonClosed\", \"Amount\"," +
                   " \"PostMotemNotes\", \"DateTimeAdded\", \"dateTimeClosed\" FROM \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\"" +
                   "where \"reasonClosed\" = '" + selectedText.ToUpper() + "' ;";

                // sql = "SELECT * FROM \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\" where \"reasonClosed\" = '" + selectedText.ToUpper() + "' ;";









                NpgsqlCommand MyCommand = con.CreateCommand();

                MyCommand.CommandText = sql;

                NpgsqlDataAdapter myDataAdapter = new NpgsqlDataAdapter();

                myDataAdapter.SelectCommand = MyCommand;


                DataSet myDataSet = new DataSet();
                int recexist = myDataAdapter.Fill(myDataSet);

                dt = myDataSet.Tables[0];
                return dt;
            }

            catch (Exception ex)
            {

            }
            return dt;
        }

        public static void InsertPostgresData(string decision, string indices, string notes, string open)
        {
            try
            {
                var con = CreatePostgresConnection();

                NpgsqlCommand sqlite_cmd;
                sqlite_cmd = con.CreateCommand();
                //
                sqlite_cmd.CommandText = "INSERT INTO \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\"( \"Decision\", \"Notes\", \"Indicies\", \"Status\",\"DateTimeAdded\")VALUES('" + decision.ToUpper() + "', '" + indices + "', '" + notes + "','" + open.ToUpper() + "','" + DateTime.Now + "');";
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        public void UpdatePostgresData(string Id, string status, string prof, string amount, string PostmotemNotes)
        {
            try
            {
                var con = CreatePostgresConnection();

                NpgsqlCommand sqlite_cmd;
                sqlite_cmd = con.CreateCommand();
                //
                sqlite_cmd.CommandText = "UPDATE \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\" SET  \"Status\"='" + status + "'," +
                    " \"reasonClosed\"='" + prof + "'," +" \"Amount\"='" + amount + "', \"dateTimeClosed\"='" + DateTime.Now + "', \"PostMotemNotes\"='" + PostmotemNotes + "'" +
                    " WHERE \"TradeId\"='" + Id + "';";
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        public string ReadSumOfProfits()
        {
            var sql = "";


            try
            {
                var con = CreatePostgresConnection();
                string myTexy = "";
                sql = "SELECT sum(\"Amount\") FROM \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\";";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    myTexy = reader.GetValue(0).ToString();

                }

                return myTexy;

            }

            catch (Exception ex)
            {
                return "";
            }

        }

        public string countAllProfits(string profitLoss)
        {
            var sql = "";


            try
            {
                var con = CreatePostgresConnection();
                string myTexy = "";
                if(profitLoss.ToUpper().Equals("PROFIT"))
                {
                    sql = "SELECT count(*) as profit FROM \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\" WHERE \"Amount\" > 0;";
                }
                else
                {
                    sql = "SELECT count(*) as profit FROM \"Forex_" + GlobalVariables.DataBase + "\".\"PlaceTrades\" WHERE \"Amount\" < 0;";
                }

                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                NpgsqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    myTexy = reader.GetValue(0).ToString();

                }

                return myTexy;

            }

            catch (Exception ex)
            {
                return "";
            }

        }


    }

}
        