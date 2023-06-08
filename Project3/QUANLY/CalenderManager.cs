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
    public partial class CalenderManager : Form
    {
        Nhanvien nv = new Nhanvien();
        
        public CalenderManager()
        {
            InitializeComponent();
        }

        private void makeCalButton_Click(object sender, EventArgs e)
        {
            MyDB db = new MyDB();
            SqlCommand command1 = new SqlCommand("Delete from calam", db.GetConnection);
            db.openConnection();
            command1.ExecuteNonQuery();
            db.closeConnection();
            Nhanvien nhanvien = new Nhanvien();
            string[,] ChiaCa = new string[3, 7];
            string[,] ChiaCaQL = new string[3, 7];
            nhanvien.MakeCalendarEmployee(ref ChiaCa);
            nhanvien.MakeCalendarManager(ref ChiaCaQL);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    string calam;
                    string thu;
                    string[] manv;
                    manv = ChiaCa[i, j].Split(',');
                    string manvQL = ChiaCaQL[i, j].Trim();
                    calam = "c" + (i + 1);
                    /*if(j+2==8)
                    {
                        thu = "cn";
                    }
                    else
                    { */
                    thu = "t" + (j + 2);
                    foreach (string manvs in manv)
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO calam (manv,ca,thu)" + "VALUES(@manv,@calam,@thu)", db.GetConnection);
                        command.Parameters.Add("@manv", SqlDbType.Char).Value = manvs;
                        command.Parameters.Add("@calam", SqlDbType.Char).Value = calam;
                        command.Parameters.Add("@thu", SqlDbType.Char).Value = thu;

                        db.openConnection();

                        command.ExecuteNonQuery();
                        db.closeConnection();
                    }

                    SqlCommand command2 = new SqlCommand("INSERT INTO calam (manv,ca,thu)" + "VALUES(@manv,@calam,@thu)", db.GetConnection);
                    command2.Parameters.Add("@manv", SqlDbType.Char).Value = manvQL;
                    command2.Parameters.Add("@calam", SqlDbType.Char).Value = calam;
                    command2.Parameters.Add("@thu", SqlDbType.Char).Value = thu;

                    db.openConnection();

                    command2.ExecuteNonQuery();
                    db.closeConnection();
                }
            }
            CalenderManager_Load(this, new EventArgs());
        }

        private void CalenderManager_Load(object sender, EventArgs e)
        {
            List<Panel> listPanel = new List<Panel>();
            List<Label> listLabel = new List<Label>();
            listPanel.Add(c1t2);
            listPanel.Add(c1t3);
            listPanel.Add(c1t4);
            listPanel.Add(c1t5);
            listPanel.Add(c1t6);
            listPanel.Add(c1t7);
            listPanel.Add(c1t8);
            listPanel.Add(c2t2);
            listPanel.Add(c2t3);
            listPanel.Add(c2t4);
            listPanel.Add(c2t5);
            listPanel.Add(c2t6);
            listPanel.Add(c2t7);
            listPanel.Add(c2t8);
            listPanel.Add(c3t2);
            listPanel.Add(c3t3);
            listPanel.Add(c3t4);
            listPanel.Add(c3t5);
            listPanel.Add(c3t6);
            listPanel.Add(c3t7);
            listPanel.Add(c3t8);
            listLabel.Add(label11);
            listLabel.Add(label12);
            listLabel.Add(label13);
            listLabel.Add(label14);
            listLabel.Add(label15);
            listLabel.Add(label16);
            listLabel.Add(label17);
            listLabel.Add(label18);
            listLabel.Add(label19);
            listLabel.Add(label20);
            listLabel.Add(label21);
            listLabel.Add(label22);
            listLabel.Add(label23);
            listLabel.Add(label24);
            listLabel.Add(label25);
            listLabel.Add(label26);
            listLabel.Add(label27);
            listLabel.Add(label28);
            listLabel.Add(label29);
            listLabel.Add(label30);
            listLabel.Add(label31);
            DataTable table = new DataTable();
            int thu = 2;
            int ca = 1;
            int j = 0;
            foreach (var item in listPanel)
            {
                table = nv.getCaLam(ca, thu);
                Label lb = new Label();
                item.Controls.Add(lb);
                string txt = "";
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    txt += table.Rows[i][0].ToString().Trim() + ": " + table.Rows[i][1].ToString().Trim() + '\n';
                    if (table.Rows[i][0].ToString().Trim()== MainForm.manv.Trim())
                    listPanel[j].BackColor = Color.Yellow;
                }
                listLabel[j].Text = txt;
                j++;
                thu++;
                if (thu > 8)
                {
                    thu = 2;
                    ca++;
                }
            }
        }
    }
}
