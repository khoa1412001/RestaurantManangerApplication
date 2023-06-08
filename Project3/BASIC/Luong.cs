using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3.BASIC
{
    public partial class Luong : Form
    {
        public Luong()
        {
            InitializeComponent();
        }

        private void Luong_Load(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            SqlCommand command = new SqlCommand("SElect distinct manv from chamcong where ngay = @thu");
            command.Parameters.Add("@thu", SqlDbType.VarChar).Value = DateTime.Now.DayOfWeek.ToString();
            DataTable table = new DataTable();
            table = nv.getNV(command);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                SqlCommand command1 = new SqlCommand();
                command1.CommandText = "select giolam from chamcong where manv = @ma and ngay = @thu";
                command1.Parameters.Add("@ma", SqlDbType.VarChar).Value = table.Rows[i][0].ToString();
                command1.Parameters.Add("@thu", SqlDbType.VarChar).Value = DateTime.Now.DayOfWeek.ToString();
                DataTable table1 = new DataTable();
                table1 = nv.getNV(command1);
                int luong = 0;
                int temp = 0;
                for (int j = 0; j < table1.Rows.Count; j++)
                {
                    temp += int.Parse(table1.Rows[j][0].ToString());
                }
                luong += temp * 50000;
                if (temp < 8) luong -= 100000 * (8 - temp);
                else if (temp > 8) luong += 100000 * (temp - 8);
                nv.LuongToday(table.Rows[i][0].ToString(), luong);
                table1.Dispose();
                command1.Dispose();
            }
            SqlCommand command2 = new SqlCommand("SELECT manv,luong from Luong where ngay=@ngay");
            command2.Parameters.Add("@ngay", SqlDbType.Date).Value = DateTime.Now.Date;
            table = nv.getNV(command2);
            dataGridView1.DataSource = table;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
