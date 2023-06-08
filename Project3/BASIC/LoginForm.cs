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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MyDB db = new MyDB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM account WHERE Username = @User AND Password = @Pass", db.GetConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBoxPassword.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MainForm mainForm = new MainForm();
                mainForm.chucvu = table.Rows[0][2].ToString().Trim();
                MainForm.manv = table.Rows[0][3].ToString();
                this.Hide();
                DialogResult result = mainForm.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    mainForm.Dispose();
                    this.Show();
                }
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                buttonLogin_Click(sender, e);
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MainFormGuest mainFormGuest = new MainFormGuest();
            //DialogResult result = mainFormGuest.ShowDialog();
            //if (result == DialogResult.Cancel)
            //{
            //    mainFormGuest.Dispose();
            //    this.Show();
            //}
            MainFormGuest mainFormGuest = new MainFormGuest();
            mainFormGuest.Show();
        }
    }
}
