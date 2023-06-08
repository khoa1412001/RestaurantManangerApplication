using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Bill
    {
        MyDB db = new MyDB();

        public bool CreateNewBill(int TableID,ref int BillID)
        {
            int tempBillID = CreateBillID();
            SqlCommand command = new SqlCommand("INSERT INTO BillInfo (id,idTable,datecheckin) VALUES(@id,@idTable,@checkin)",db.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = tempBillID;
            command.Parameters.Add("@idTable", SqlDbType.Int).Value = TableID;
            command.Parameters.Add("@checkin", SqlDbType.DateTime).Value= DateTime.Now;

            db.openConnection();

            if(command.ExecuteNonQuery()==1)
            {
                db.closeConnection();
                BillID = tempBillID;
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public bool UpdateBill(int TableID,int BillID,int BillTotal = 0)
        {
            SqlCommand command = new SqlCommand("UPDATE BillInfo SET datecheckout = @dco,billTotal = @bt  WHERE id=@idb AND idTable = @idt", db.GetConnection);
            command.Parameters.Add("@dco", SqlDbType.DateTime).Value = DateTime.Now;
            command.Parameters.Add("@idb", SqlDbType.Int).Value = BillID;
            command.Parameters.Add("@idt", SqlDbType.Int).Value = TableID;
            command.Parameters.Add("@bt", SqlDbType.Int).Value = BillTotal;
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
        public DataTable GetBill(int TableID,int BillID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM BillInfo WHERE id = @idb AND idTable = @idt", db.GetConnection);
            command.Parameters.Add("@idb", SqlDbType.Int).Value = BillID;
            command.Parameters.Add("@idt", SqlDbType.Int).Value = TableID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool InsertOrder(int TableID,int BillID,string fName, int NumberOfFood)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Bill (idBill, idTable, foodname, count) VALUES (@idb, @idt, @fn, @count)", db.GetConnection);
            command.Parameters.Add("@idb", SqlDbType.Int).Value = BillID;
            command.Parameters.Add("@idt", SqlDbType.Int).Value = TableID;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fName;
            command.Parameters.Add("@count", SqlDbType.Int).Value = NumberOfFood;

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

        public DataTable GetBillInfo(int TableID, int BillID)
        {
            SqlCommand command = new SqlCommand("SELECT Bill.foodname as 'Tên món ăn',menu.gia as 'Đơn giá',sum(Bill.count) as 'Số Lượng' FROM Bill INNER JOIN menu ON Bill.foodname = menu.monan WHERE Bill.idBill = @idb AND Bill.idTable = @idt GROUP BY Bill.foodname, menu.gia", db.GetConnection);
            command.Parameters.Add("@idb", SqlDbType.Int).Value = BillID;
            command.Parameters.Add("@idt", SqlDbType.Int).Value = TableID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable GetBillByDate(DateTime dateTime)
        {
            string[] temp = dateTime.ToShortDateString().Split('/');
            string dateTimeTrue = "";
            dateTimeTrue = temp[2] + "-" + temp[1] + "-" + temp[0];
            SqlCommand command = new SqlCommand("SELECT id, BillTotal FROM BillInfo WHERE BillInfo.datecheckout >= @datetime AND BillInfo.datecheckout < DATEADD(DAY,1,@datetime)", db.GetConnection);
            command.Parameters.Add("@datetime", SqlDbType.VarChar).Value = dateTimeTrue;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private int CreateBillID()
        {
            int BillID = 1;
            for (int i = 1; i < 200; i++)
            {
                int TempBillID = i;
                SqlCommand command2 = new SqlCommand("SELECT * FROM BillInfo WHERE id = @id", db.GetConnection);
                command2.Parameters.Add("@id", SqlDbType.Int).Value = TempBillID;
                SqlDataAdapter adapter = new SqlDataAdapter(command2);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    continue;
                }
                else
                {
                    BillID = TempBillID;
                    break;
                }
            }
            return BillID;
        }

        public bool DeleteAllBill()
        {
            SqlCommand command = new SqlCommand("DELETE FROM Bill", db.GetConnection);
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
