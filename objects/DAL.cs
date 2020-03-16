using forex.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void InsertData(string decision, string notes, string open)
        {
            conn = CreateConnection();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO PlaceTrades(Decision,Notes,Status,DateOpened) VALUES('" + decision+"','"+notes+"','"+open+"','"+DateTime.Now+"');";
            sqlite_cmd.ExecuteNonQuery();

        }

        public DataTable ReadData()
        {
        conn = CreateConnection();
                

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();

            string CommandText = "SELECT Id AS [Trade ID], Decision AS [Trade Decision],Notes,Status AS[Trade Status], reasonClosed AS [trade Closed Reason], Amount,DateOpened as[Date and time Of Trades] FROM PlaceTrades";

            DB = new SQLiteDataAdapter(CommandText, conn);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];

            return DT;

              //  Grid.DataSource = DT;
            sql_con.Close();
           

        }

        public DataTable ReadDataSome(string searchBy)
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

        public DataTable ReadStatusData(string searchBy)
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

        public DataTable ReadDecisionData()
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

        public DataTable ReadTradedsDataOnSelectedText(string selectedText)
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

        public void udpateRecords(string Id, string status, string prof, string amount)
        {
            conn = CreateConnection();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "UPDATE PlaceTrades SET Status = '"+ status + "',reasonClosed = '" + prof + "', Amount = '"+ amount + "' , dateTimeClosed = '" + DateTime.Now + "' WHERE Id = '" + Id+"';";
            sqlite_cmd.ExecuteNonQuery();

        }

    }
}