using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Table
    {
        MyDB db = new MyDB();
        public bool InsertNewTable()
        {
            SqlCommand command = new SqlCommand("INSERT INTO tableInfo (id,empty,numberofpeople,idBill) VALUES (@id,@empty,@numberofpeople,@idb)", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = CreateTableID();
            command.Parameters.Add("@empty", SqlDbType.Int).Value = 0;
            command.Parameters.Add("@numberofpeople", SqlDbType.Int).Value = 0;
            command.Parameters.Add("@idb", SqlDbType.Int).Value = 0;

            db.openConnection();

            if(command.ExecuteNonQuery()==1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool UpdateTableStatus(int tableID,int status,int numberofpeople,int BillID)
        {
            SqlCommand command = new SqlCommand("UPDATE tableInfo SET empty = @status, numberofpeople = @nop, idBill = @idb WHERE id = @id", db.GetConnection);
            command.Parameters.Add("@status", SqlDbType.Int).Value = status;
            command.Parameters.Add("@nop", SqlDbType.Int).Value = numberofpeople;
            command.Parameters.Add("@id", SqlDbType.Int).Value = tableID;
            command.Parameters.Add("@idb", SqlDbType.Int).Value = BillID;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public DataTable GetTable()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tableInfo", db.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable GetTableInfoByID(int tableID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tableInfo WHERE id = @idt", db.GetConnection);
            command.Parameters.Add("@idt", SqlDbType.Int).Value = tableID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private int CreateTableID()
        {
            int TableID = 1;
            for (int i = 1; i < 200; i++)
            {
                int TempTableID = i;
                SqlCommand command2 = new SqlCommand("SELECT * FROM tableInfo WHERE id = @id", db.GetConnection);
                command2.Parameters.Add("@id", SqlDbType.Int).Value = TempTableID;
                SqlDataAdapter adapter = new SqlDataAdapter(command2);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    continue;
                }
                else
                {
                    TableID = TempTableID;
                    break;
                }
            }
            return TableID;
        }

        public bool DeleteTable(int tableID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM tableInfo WHERE id = @id", db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = tableID;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
