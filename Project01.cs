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
    public partial class Project01 : Form
    {
        public Project01()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            ChooseForm cf = new ChooseForm();
            cf.Show();
            this.Hide();

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ReserchProj ResP = new ReserchProj();
            ResP.Show();
            this.Hide();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ProjRemv Prmv = new ProjRemv();
            Prmv.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            ViewProj Vp = new ViewProj();
            Vp.Show();
            this.Hide();
        }
    }
}
