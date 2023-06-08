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
    public partial class MainForm : Form
    {
        public string chucvu;
        public static string manv;
        DateTime checkin;
        private int iTimer = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkoutButton.Enabled = false;
            timer1.Start();
            if (chucvu == "1")
            {
                chucvu = "Quản lý";
            }
            else
            {
                chucvu = "Nhân viên";
                managerButton.Enabled = false;
                calManagerButton.Enabled = false;
                registerButton.Enabled = false;
            }
            LoadTable();
            MessageBox.Show(("Đăng nhập với chức vụ " + chucvu),"Đăng nhập thành công!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show(); 

        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            DateTime checkout = DateTime.Now.AddHours(8);
            Nhanvien nhanvien = new Nhanvien();
            if (nhanvien.ChamCong(manv,checkin,checkout))
                MessageBox.Show("Chấm công thành công", "Chấm công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Chấm công thất bại\n Vui lòng báo cho quản lý", "Chấm công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BASIC.Luong fr = new BASIC.Luong();
            fr.ShowDialog();
        }

        private void checkinButton_Click(object sender, EventArgs e)
        {
            checkoutButton.Enabled = true;
            checkinButton.Enabled = false;
            checkin = DateTime.Now;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.manv = manv;
            changePasswordForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DigiClock.Text = DateTime.Now.ToString("HH:mm:ss");
            if (DigiClock.Text == "22:05:00")
            {
                BASIC.Luong fr = new BASIC.Luong();
                fr.ShowDialog();
            }
            if (checkinButton.Enabled == false)
                if (DigiClock.Text == "10:55:00" || DigiClock.Text == "13:55:00" || DigiClock.Text == "21:55:00")
                    MessageBox.Show("Nhớ Check Out để kết thúc ca làm của bạn", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            iTimer++;
            if (iTimer == 5)
            {
                LoadTable();
                iTimer = 0;
            }
        }
        private void TinhLuong()
        {
            
        }
        private void informationButton_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm();
            informationForm.Show();
        }

        private void calManagerButton_Click(object sender, EventArgs e)
        {
            CalenderManager calenderManager = new CalenderManager();
            calenderManager.Show();
        }


        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.InsertNewTable();
            LoadTable();
        }
        private void LoadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            Table table = new Table();
            DataTable tableS = table.GetTable();
            if (tableS.Rows.Count > 0)
            {
                for (int i = 0; i < tableS.Rows.Count; i++)
                {
                    Button btn = new Button() { Width = 100, Height = 100 };
                    btn.Text = "Bàn " + tableS.Rows[i][0].ToString();
                    if((int)tableS.Rows[i][1]==1)
                    {
                        btn.BackColor = Color.Red;

                    }
                    else
                    {
                        if((int)tableS.Rows[i][1]==2)
                        {
                            btn.BackColor = Color.Blue;
                        }
                        else
                        {
                            btn.BackColor = Color.Green;
                        }
                    }
                    btn.Click += btn_Click; 
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }

        }
        void btn_Click(object sender, EventArgs e)
        {
            string TableID = (sender as Button).Text;
            TableForm tableForm = new TableForm();
            tableForm.TableID = TableID;
            tableForm.Show();
        }

        private void checkCalButton_Click(object sender, EventArgs e)
        {
            NHANVIEN.Calendar calenderForm = new NHANVIEN.Calendar();
            calenderForm.Show();
        }

        private void buttonDeleteBill_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.DeleteAllBill();
        }

        private void buttonStatic_Click(object sender, EventArgs e)
        {
            QUANLY.StaticForm fr = new QUANLY.StaticForm();
            fr.ShowDialog();
        }
    }
}
