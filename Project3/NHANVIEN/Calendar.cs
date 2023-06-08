using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3.NHANVIEN
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }
        Nhanvien nv = new Nhanvien();

        private void Calendar_Load(object sender, EventArgs e)
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
                    if (table.Rows[i][0].ToString().Trim() == MainForm.manv.Trim())
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
