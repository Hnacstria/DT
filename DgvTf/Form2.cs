using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DgvTf
{
    public partial class FormSohran : Form
    {
        public FormSohran()
        {
            InitializeComponent();
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 7;
        }

        private void buttonSohr_Click(object sender, EventArgs e)
        {
            StreamWriter sw0 = new StreamWriter(@"C:\GITHUB\DGVTf1\text.txt", false, Encoding.ASCII);
            sw0.Write("");
            sw0.Close();

            StreamWriter sw = new StreamWriter(@"C:\GITHUB\DGVTf1\text.txt", true, Encoding.ASCII);

            for (int x = 0; x < 7; x++)//столбцы
            {
                for (int y = 0; y < 10; y++)//строки
                {
                    sw.WriteLine(dataGridView1[x, y].Value);
                }
            }
            sw.Close();
        }
    }
}
