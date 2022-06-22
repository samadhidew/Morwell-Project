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
    public partial class Course01 : Form
    {
        public Course01()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            ChooseForm cf = new ChooseForm();
            cf.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Course curs = new Course();
            curs.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            RemvCourses Rc = new RemvCourses();
            Rc.Show();
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            ViewCourse Vc = new ViewCourse();
            Vc.Show();
            this.Hide();

        }
    }
}
