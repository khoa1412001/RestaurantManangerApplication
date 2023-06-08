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
    public partial class OrderFoodForm : Form
    {
        MyDB db = new MyDB();
        public int TableID;
        public int BillID;
        int Sum = 0;
        public OrderFoodForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillDataGridView()
        {
            SqlCommand command = new SqlCommand("SELECT monan as 'Tên món ăn', gia as 'Giá',0 as 'Số lượng' FROM menu", db.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            //
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Thêm";
            btn.Text = "+";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            //
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn1);
            btn1.HeaderText = "Loại";
            btn1.Text = "-";
            btn1.Name = "btn";
            btn1.UseColumnTextForButtonValue = true;
            //
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void OrderFoodForm_Load(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if(e.ColumnIndex == 3)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value + 1;
                }
                if (e.ColumnIndex == 4)
                {
                    if ((int)dataGridView1.Rows[e.RowIndex].Cells[2].Value > 0)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value - 1;
                    }
                }
                CalculateBill();
            }
        }
        private void CalculateBill()
        {
            Sum = 0;
            if(dataGridView1.Rows.Count > 0)
            {
                for(int i = 0;i < dataGridView1.Rows.Count;i++)
                {
                    Sum += (int)dataGridView1.Rows[i].Cells[1].Value * (int)dataGridView1.Rows[i].Cells[2].Value;
                }
            }
            labelSum.Text = "Tổng: " + Sum;
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            Food food = new Food();
            int breakoccur = 0;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if((int)dataGridView1.Rows[i].Cells[2].Value>0)
                    {
                        
                        string fName = dataGridView1.Rows[i].Cells[0].Value.ToString().Trim();
                        int NumberOfPlate = (int)dataGridView1.Rows[i].Cells[2].Value;
                        if ((bill.InsertOrder(TableID, BillID, fName, NumberOfPlate)) && (food.UpgradeIngrediantAfterOrder(fName, NumberOfPlate)))
                        {
                           
                        }
                        else
                        {
                            breakoccur = 1;
                            break;
                        }
                    }
                }
                if (breakoccur == 0)
                {
                    MessageBox.Show("Order Thành Công", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Một Vài Order Không Thành Công Vui Lòng Chọn Món Khác", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }          
        }
    }
}
