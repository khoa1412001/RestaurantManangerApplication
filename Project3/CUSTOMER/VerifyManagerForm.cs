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
    public partial class VerifyManagerForm : Form
    {
        public int TableID;
        public VerifyManagerForm()
        {
            InitializeComponent();
        }

        private void buttonVerify_Click(object sender, EventArgs e)
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
                string chucvu = table.Rows[0][2].ToString().Trim();
                if (chucvu == "1")
                {
                    TableID = Convert.ToInt32(comboBoxSelectTable.Text);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Không phải là quản lý", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void fillComboBox()
        {
            Table table = new Table();
            comboBoxSelectTable.DataSource = table.GetTable();
            comboBoxSelectTable.DisplayMember = "id";
            comboBoxSelectTable.ValueMember = "id";
            comboBoxSelectTable.SelectedItem = null;
        }

        private void VerifyManagerForm_Load(object sender, EventArgs e)
        {
            fillComboBox();
        }
    }
}
