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

namespace Project3.QUANLY
{
    public partial class StaticForm : Form
    {
        public StaticForm()
        {
            InitializeComponent();
        }

        private void StaticForm_Load(object sender, EventArgs e)
        {
            Food food = new Food();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Select monan from menu");
            table = food.getRequest(command);
            for (int i=0;i<table.Rows.Count;i++)
            {
                SqlCommand command1 = new SqlCommand("select sum(count) from Bill where foodname = @name");
                command1.Parameters.Add("@name", SqlDbType.NVarChar).Value = table.Rows[i][0].ToString();
                DataTable table1 = new DataTable();
                table1 = food.getRequest(command1);
                chartDay.Series["Số lượng"].Points.AddXY(table.Rows[i][0].ToString(), int.Parse(table1.Rows[0][0].ToString()));
                table1.Dispose();
                command1.Dispose();
            }
            //
            Bill bill = new Bill();
            DateTime dateTime = dateTimePickerBill.Value;
            DataTable tableSource = bill.GetBillByDate(dateTime);
            CalculateBill(tableSource);

        }
        private void CalculateBill(DataTable tableSource)
        {
            int Sum = 0;
            if(tableSource.Rows.Count>0)
            {
                for (int i = 0; i < tableSource.Rows.Count; i++)
                {
                    Sum +=  (int)tableSource.Rows[i][1];
                }
            }
            labelSumOfBill.Text = "TỔNG THU: " + Sum;
        }

        private void dateTimePickerBill_ValueChanged(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            DateTime dateTime = dateTimePickerBill.Value;
            DataTable tableSource = bill.GetBillByDate(dateTime);
            CalculateBill(tableSource);
        }
    }
}
