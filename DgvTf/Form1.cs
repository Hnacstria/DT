using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DgvTf
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSohr_Click(object sender, EventArgs e)
        {
            Form f1 = new FormSohran();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }

        private void buttonZagr_Click(object sender, EventArgs e)
        {
            Form f1 = new FormZagr();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }
    }
}
