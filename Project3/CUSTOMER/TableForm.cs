using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DGVPrinterHelper;


namespace Project3
{
    public partial class TableForm : Form
    {
        public string TableID;
        private int Sum = 0;
        private int iTimer = 0;
        
        public TableForm()
        {
            InitializeComponent();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTableID.Text = TableID;
            LoadBill();
        }

        private void LoadBill()
        {
            string tempTableID = Regex.Replace(TableID, "[^0-9.]", "");
            int iTableID = Int32.Parse(tempTableID);
            Bill bill = new Bill();
            Table table = new Table();
            DataTable tableDT = table.GetTableInfoByID(iTableID);
            labelInfo.Text ="Mã số: "+ (int)tableDT.Rows[0][3];
            numericUpDownNumberOfPeople.Value = (int)tableDT.Rows[0][2];
            //
            DataTable tableSource = bill.GetBillInfo(iTableID, (int)tableDT.Rows[0][3]);
            AddRow(ref tableSource);
            dataGridView1.DataSource = tableSource;
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
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    Sum += (int)dataGridView1.Rows[i].Cells[1].Value * (int)dataGridView1.Rows[i].Cells[2].Value;
                }
            }
            labelSum.Text = "Tổng: " + Sum;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DigiClock.Text = DateTime.Now.ToString("HH:mm:ss");
            if(iTimer == 5)
            {
                //LoadBill();
                iTimer = 0;
            }
            iTimer++;
        }   

        private void buttonMakeBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xuất hóa đơn cho bàn này ?", "Xuất hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string tempTableID = Regex.Replace(TableID, "[^0-9.]", "");
                int iTableID = Int32.Parse(tempTableID);
                Bill bill = new Bill();
                Table table = new Table();
                DataTable tableDT = table.GetTableInfoByID(iTableID);
                MakeBill();
                bill.UpdateBill(iTableID, (int)tableDT.Rows[0][3],Sum);
                table.UpdateTableStatus(iTableID, 0, 0, 0);
                this.Close();
            }
        }

        private void MakeBill()
        {
            string tempTableID = Regex.Replace(TableID, "[^0-9.]", "");
            int iTableID = Int32.Parse(tempTableID);
            Bill bill = new Bill();
            Table table = new Table();
            DataTable tableDT = table.GetTableInfoByID(iTableID);
            if (dataGridView1.Rows.Count > 0)
            {
                DataTable DTable = bill.GetBill(iTableID, (int)tableDT.Rows[0][3]);
                DataGridView dgv = dataGridView1;
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "The Food House: Receipt \n" +labelInfo.Text;
                printer.SubTitle = "Giờ Check-in: "+ DTable.Rows[0][2].ToString() +"        "+"Giờ Check-out: "+DateTime.Now.ToString();
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "XIN CẢM ƠN";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dataGridView1);
            }
        }

        private void AddRow(ref DataTable tableSource)
        {
            DataRow dataRow = tableSource.NewRow();
            dataRow[0] = "TỔNG: ";
            dataRow[2] = Sum;
            tableSource.Rows.Add(dataRow);
            tableSource.AcceptChanges();
            CalculateTable(tableSource);
        }
        private void CalculateTable(DataTable TableSource)
        {
            int TSum = 0;
            if (TableSource.Rows.Count > 1)
            {
                for (int i = 0; i < TableSource.Rows.Count - 1; i++)
                {
                    TSum += (int)TableSource.Rows[i][1] * (int)TableSource.Rows[i][2];
                }
            }
            TableSource.Rows[TableSource.Rows.Count - 1][2] = TSum;
            TableSource.AcceptChanges();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string tempTableID = Regex.Replace(TableID, "[^0-9.]", "");
            int iTableID = Int32.Parse(tempTableID);
            if (MessageBox.Show("Bạn có chắc muốn xóa bàn này ?", "Xóa bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Table table = new Table();
                if(table.DeleteTable(iTableID))
                {
                    MessageBox.Show("Xóa bàn thành công", "Xóa bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa bàn thành công", "Xóa bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
