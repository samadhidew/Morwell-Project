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
    public partial class LecRemv : Form
    {
        public LecRemv()
        {
            InitializeComponent();
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Lectures01 Lec1 = new Lectures01();
            Lec1.Show();
            this.Hide();

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            int lectureID = int.Parse(bunifuMaterialTextbox3.Text);

            String del = "DELETE FROM  Lecturer where ID =" + lectureID + "";

            DBConnection dbc = new DBConnection();
            string feedback = dbc.DBCon(del);

            MessageBox.Show(feedback);
            bunifuMaterialTextbox3.Text = "";
        }
    }
}
