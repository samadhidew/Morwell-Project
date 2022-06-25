using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LecViewDetal : Form
    {
        public LecViewDetal()
        {
            InitializeComponent();
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Lectures01 lec1 = new Lectures01();
            lec1.Show();
            this.Hide();

        }

        private void LecViewDetal_Load(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Project\WindowsFormsApp1\DatabaseCP.mdf;Integrated Security=True";
            string qry = "SELECT * FROM Lecturer";



            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Lecturer");
                dataGridView1.DataSource = ds.Tables["Lecturer"];
            }



            catch (SqlException SE)
            {
                MessageBox.Show(SE.ToString());
            }
        }
    }
}
