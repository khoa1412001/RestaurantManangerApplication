using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Nhanvien
    {
        MyDB mydb = new MyDB();
        public DataTable getNhanvien(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool DeleteEmployee(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM thongtinnv WHERE manv = @manv", mydb.GetConnection);
            SqlCommand command2 = new SqlCommand("DELETE FROM account WHERE manv = @manv",mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.VarChar).Value = id;
            command2.Parameters.Add("@manv", SqlDbType.VarChar).Value = id;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1)&&(command2.ExecuteNonQuery()==1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool ChamCong(string manv,DateTime checkin,DateTime checkout)
        {
            //checkout = checkout.AddHours(8);
            SqlCommand command = new SqlCommand("INSERT INTO chamcong (manv, checkin, checkout,ngay, giolam)" + "VALUES (@manv,@checkin,@checkout,@ngay,@giolam)", mydb.GetConnection);
            command.Connection = mydb.GetConnection;
            command.Parameters.Add("@manv", SqlDbType.Char).Value = manv;
            command.Parameters.Add("@checkin", SqlDbType.DateTime).Value = checkin;
            command.Parameters.Add("@checkout", SqlDbType.DateTime).Value = checkout;
            command.Parameters.Add("@giolam", SqlDbType.Int).Value = Math.Round((checkout - checkin).TotalHours, 0);
            command.Parameters.Add("@ngay", SqlDbType.VarChar).Value = DateTime.Now.DayOfWeek.ToString();
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool InsertNewEmployee(string maNV,string cmnd, string hoNV, string tenNV, DateTime ngaysinh, string gioitinh, string sdt, string diachi,string chucvu, MemoryStream hinhanh)
        {
            SqlCommand command = new SqlCommand("INSERT INTO thongtinnv (manv, cmnd, hoNV, tenNV, gioitinh,ngaysinh, sdt, diachi,chucvu,luong,hinhanh)" + "VALUES (@manv,@cmnd,@honv,@tennv,@gioitinh,@ngaysinh,@sdt,@diachi,@chucvu,@luong,@hinhanh)", mydb.GetConnection);

            command.Parameters.Add("@manv", SqlDbType.VarChar).Value = maNV;
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            command.Parameters.Add("@hoNV", SqlDbType.VarChar).Value = hoNV;
            command.Parameters.Add("@tenNV", SqlDbType.VarChar).Value = tenNV;
            command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@diachi", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@chucvu", SqlDbType.VarChar).Value = chucvu;
            command.Parameters.Add("@luong", SqlDbType.Int).Value = 0;
            command.Parameters.Add("@hinhanh", SqlDbType.Image).Value = hinhanh.ToArray();

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool UpdateEmployee(string maNV, string cmnd,string hoNV, string tenNV, DateTime ngaysinh, string gioitinh, string sdt, string diachi, string chucvu,MemoryStream hinhanh)
        {
            SqlCommand command = new SqlCommand("UPDATE thongtinnv SET cmnd = @cmnd, hoNV = @hoNV, tenNV = @tenNV, ngaysinh = @ngaysinh, sdt = @sdt, diachi = @diachi, chucvu=@chucvu,hinhanh = @hinhanh WHERE manv = @manv", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.VarChar).Value = maNV;
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            command.Parameters.Add("@hoNV", SqlDbType.VarChar).Value = hoNV;
            command.Parameters.Add("@tenNV", SqlDbType.VarChar).Value = tenNV;
            command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@diachi", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@chucvu", SqlDbType.VarChar).Value = chucvu;
            command.Parameters.Add("@hinhanh", SqlDbType.Image).Value = hinhanh.ToArray();

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public void MakeCalendarEmployee(ref string[,] ChiaCa)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM thongtinnv WHERE manv LIKE 'nv%'", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Random random = new Random();
            int Start = random.Next(0, table.Rows.Count);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ChiaCa[j, i] = table.Rows[Start][0].ToString()+",";
                    Start++;
                    if (Start >= table.Rows.Count)
                    {
                        Start = 0;
                    }
                    ChiaCa[j, i] += table.Rows[Start][0].ToString();
                    Start++;
                    if (Start >= table.Rows.Count)
                    {
                        Start = 0;
                    }
                }
            }
        }
        public void MakeCalendarManager(ref string[,] ChiaCa)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM thongtinnv WHERE manv LIKE 'ql%'", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Random random = new Random();
            
            int Start = random.Next(0, table.Rows.Count);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ChiaCa[j, i] = table.Rows[Start][0].ToString();
                    Start++;
                    if (Start >= table.Rows.Count)
                    {
                        Start = 0;
                    }
                }
            }
        }
        public DataTable getCaLam(int ca,int ngay)
        {
            SqlCommand command = new SqlCommand("Select thongtinnv.manv,thongtinnv.tennv from calam inner join thongtinnv on calam.manv = thongtinnv.manv where ca = @calam and thu = @day", mydb.GetConnection);
            command.Parameters.Add("@calam", SqlDbType.VarChar).Value = "c" + ca.ToString();
            command.Parameters.Add("@day", SqlDbType.VarChar).Value = "t" + ngay.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCaLamTheoManv(int ca,int ngay)
        {
            SqlCommand command = new SqlCommand("Select thongtinnv.manv,thongtinnv.tennv from calam inner join thongtinnv on calam.manv = thongtinnv.manv where ca = @calam and thu = @day AND thongtinnv.manv = @manv", mydb.GetConnection);
            command.Parameters.Add("@calam", SqlDbType.VarChar).Value = "c" + ca.ToString();
            command.Parameters.Add("@day", SqlDbType.VarChar).Value = "t" + ngay.ToString();
            command.Parameters.Add("@manv", SqlDbType.VarChar).Value = MainForm.manv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getNV(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public void LuongToday(string manv,int luong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Luong (manv,luong,ngay)" + "VALUES (@manv,@luong,@ngay)", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.VarChar).Value = manv;
            command.Parameters.Add("@luong", SqlDbType.Int).Value = luong;
            command.Parameters.Add("@ngay", SqlDbType.Date).Value = DateTime.Now.Date;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
            }
            else
            {
                mydb.closeConnection();
            }
        }
    }
}
