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
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();//Exite the form button
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Students01 st = new Students01();//Connet Student's button form
            st.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Lectures01 LeC= new Lectures01();//Connet lecture's button form
            LeC.Show();
            this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            Project01 Pro = new Project01();//Connect research project
            Pro.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Course01 curs1 = new Course01();
            curs1.Show();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Payment01 pay = new Payment01();
            pay.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Exam01 Ex1 = new Exam01();
            Ex1.Show();
            this.Hide();
        }
    }
}
