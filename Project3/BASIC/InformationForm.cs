using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class InformationForm : Form
    {
        MyDB db = new MyDB();
        public InformationForm()
        {
            InitializeComponent();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            //Lay data
            SqlCommand command = new SqlCommand("SELECT * FROM thongtinnv WHERE manv = @manv",db.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.Char).Value = MainForm.manv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            //Fill cac control
            textBoxIdentification.Text = table.Rows[0][1].ToString();
            textBoxFirstName.Text = table.Rows[0][2].ToString();
            textBoxLastName.Text = table.Rows[0][3].ToString();
            textBoxAddress.Text = table.Rows[0][7].ToString();
            textBoxPhone.Text = table.Rows[0][6].ToString();
            dateTimePickNgaySinh.Value = (DateTime)table.Rows[0][5];

            if((table.Rows[0][4].ToString()=="Nam"))
            {
                maleRadioButton.Checked = true;
            }
            else
            {
                femaleRadioButton.Checked = true;
                maleRadioButton.Checked = false;
            }

            if((table.Rows[0][8].ToString()=="0"))
            {
                employeeButton.Checked = true;
            }
            else
            {
                employeeButton.Checked = false;
                managerButton.Checked = true;
            }

            byte[] pic;
            pic = (byte[])table.Rows[0][12];
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxEmployee.Image = Image.FromStream(picture);
            //lock cac contro
            foreach (Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.ReadOnly = true;
                }

                if(control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.AutoCheck = false;
                }
            }
            this.dateTimePickNgaySinh.Enabled = false;
            employeeButton.AutoCheck = false;
            managerButton.AutoCheck = false;
        }
    }
}
