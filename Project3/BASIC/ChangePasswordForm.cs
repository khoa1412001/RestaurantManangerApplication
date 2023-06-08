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

namespace Project3
{ 
    public partial class ChangePasswordForm : Form
    {
        public string manv;
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void existButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            MyDB db = new MyDB();
            SqlCommand command = new SqlCommand("SELECT * FROM account WHERE manv = @manv", db.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            

            command.Parameters.Add("@manv", SqlDbType.VarChar).Value = manv;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(textBoxOldPassword.Text == table.Rows[0][1].ToString().Trim())
            {
                if(textBoxNewPassword.Text==textBoxConfPassword.Text)
                {
                    SqlCommand command2 = new SqlCommand("UPDATE account SET password = @pass WHERE manv = @manv",db.GetConnection);
                    command2.Parameters.Add("@pass", SqlDbType.VarChar).Value = textBoxNewPassword.Text;
                    command2.Parameters.Add("@manv", SqlDbType.VarChar).Value = manv;

                    db.openConnection();
                    if(command2.ExecuteNonQuery()==1)
                    {
                        db.closeConnection();
                        MessageBox.Show("Đổi mật khẩu thành công", "ĐỔI MẬT KHẨU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        db.closeConnection();
                        MessageBox.Show("Đổi mật khẩu không thành công", "ĐỔI MẬT KHẨU", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu mới!!", "ĐỔI MẬT KHẨU", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng", "ĐỔI MẬT KHẨU", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
