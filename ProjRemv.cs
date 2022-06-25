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
    public partial class ProjRemv : Form
    {
        public ProjRemv()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Project01 pro1 = new Project01();
            pro1.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Exit the Program?", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            int projID = int.Parse(bunifuMaterialTextbox3.Text);

            String del = "DELETE FROM  ResearchProjects where ProjectID =" + projID + "";

            DBConnection dbc = new DBConnection();
            string feedback = dbc.DBCon(del);

            MessageBox.Show(feedback);
            bunifuMaterialTextbox3.Text = "";
        }
    }
}
