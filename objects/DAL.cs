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

        public static void InsertData(string decision,string indies, string notes, string open)
        {
            try
            {
                conn = CreateConnection();

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO PlaceTrades(Decision,Notes,Status,DateOpened,Indicies) VALUES('" + decision + "','" + notes + "','" + open + "','" + DateTime.Now + "','" + indies + "');";
                sqlite_cmd.ExecuteNonQuery();
            }
            catch(Exception e)
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
                if(selectedText.ToUpper().Equals("ALL"))
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
                sqlite_cmd.CommandText = "UPDATE PlaceTrades SET Status = '"+ status + "',reasonClosed = '" + prof + "', Amount = '"+ amount + "' , dateTimeClosed = '" + DateTime.Now + "' WHERE Id = '" + Id+"';";
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        public DataTable CreateConn()
        {
            
            try
            {
                var con = CreatePostgresConnection();

                var sql = "SELECT * FROM \"Forex_STG\".\"PlaceTrades\";";

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

    }
}