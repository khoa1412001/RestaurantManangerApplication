using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class MainFormGuest : Form
    {
        public int TableID;
        public int BillID;
        private int Sum = 0;
        public MainFormGuest()
        {
            InitializeComponent();
        }

        private void buttonSelectTable_Click(object sender, EventArgs e)
        {
            VerifyManagerForm verifyManagerForm = new VerifyManagerForm();
            verifyManagerForm.ShowDialog();
            labelTableID.Text = "Bàn: " + verifyManagerForm.TableID;
            TableID = verifyManagerForm.TableID;
            checkinButton.Enabled = true;
        }

        private void MainFormGuest_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTableID.Text = "Bàn: ";
            checkoutButton.Enabled = false;
            buttonOrder.Enabled = false;
            checkinButton.Enabled = false;
        }
        

        private void checkinButton_Click(object sender, EventArgs e)
        {
            if (numericUpDownNumberOfPeople.Value > 0)
            {
                Bill bill = new Bill();
                Table table = new Table();
                bill.CreateNewBill(TableID, ref BillID);
                if (table.UpdateTableStatus(TableID, 1, (int)numericUpDownNumberOfPeople.Value,BillID))
                {
                    MessageBox.Show("Check-in thành công", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkinButton.Enabled = false;
                    checkoutButton.Enabled = true;
                    buttonOrder.Enabled = true;
                    numericUpDownNumberOfPeople.Enabled = false;
                    labelInfo.Text += BillID.ToString();
                }
                else
                {
                    MessageBox.Show("Check-in không thành công", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }            
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số người hợp lệ", "Check-in", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thanh toán ?", "Thanh Toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Table table = new Table();
                table.UpdateTableStatus(TableID, 2, (int)numericUpDownNumberOfPeople.Value, BillID);
                labelInfo.Text = "Mã số: ";
                checkinButton.Enabled = true;
                checkoutButton.Enabled = false;
                buttonOrder.Enabled = false;
                numericUpDownNumberOfPeople.Enabled = true;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
            }    
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            OrderFoodForm orderFoodForm = new OrderFoodForm();
            orderFoodForm.TableID = TableID;
            orderFoodForm.BillID = BillID;
            orderFoodForm.ShowDialog();
            LoadBill();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DigiClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void LoadBill()
        {
            Bill bill = new Bill();
            dataGridView1.DataSource = bill.GetBillInfo(TableID, BillID);
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            CalculateBill();
        }
        private void CalculateBill()
        {
            Sum = 0;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Sum += (int)dataGridView1.Rows[i].Cells[1].Value * (int)dataGridView1.Rows[i].Cells[2].Value;
                }
            }
            labelSum.Text = "Tổng: " + Sum;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
