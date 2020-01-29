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
    public partial class FormZagr : Form
    {
        public FormZagr()
        {
            InitializeComponent();
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 7;
        }

        private void buttonZagr_Click(object sender, EventArgs e)
        {
            string path = @"C:\GITHUB\DGVTf1\text.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    for (int x = 0; x < 7; x++)
                    {
                        for (int y = 0; y < 10; y++)
                        {
                            string line = sr.ReadLine();
                            dataGridView1[x, y].Value = line;
                        }
                    }
                }
            }
            catch { MessageBox.Show("Файла нет"); }
        }
    }
}