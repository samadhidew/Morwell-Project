using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Exam01 : Form
    {
        public Exam01()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            AssigningGrade AsG = new AssigningGrade();
            AsG.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ResitRegis ResR = new ResitRegis();
            ResR.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            ChooseForm cf = new ChooseForm();
            cf.Show();
            this.Hide();
        }
    }
}
