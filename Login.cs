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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string password = textBox2.Text;


            if(UserName=="admin"&& password == "admin123")
            {
                ChooseForm cf = new ChooseForm();
                cf.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Incorrrect UserName or Password!");
            }
        }

        private void label22_Click(object sender, EventArgs e)
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
    }
}
