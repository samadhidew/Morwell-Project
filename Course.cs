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
    public partial class Course : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Project\WindowsFormsApp1\DatabaseCP.mdf;Integrated Security=True");

        public Course()
        {
            InitializeComponent();
        }

        public void ID()
        {
            try
            {
                string ID;
                string query = "select CourseID from Course order by CourseID Desc";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int id = int.Parse(dr[0].ToString()) + 1;
                    ID = id.ToString("00000");
                }
                else if (Convert.IsDBNull(dr))
                {
                    ID = ("00001");
                }
                else
                {
                    ID = ("00001");
                }
                con.Close();

                bunifuMaterialTextbox1.Text = ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Course_Load(object sender, EventArgs e)
        {
            ID();

            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Project\WindowsFormsApp1\DatabaseCP.mdf;Integrated Security=True";
            string qry = "SELECT * FROM Course";



            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Course");
                dataGridView1.DataSource = ds.Tables["Course"];
            }



            catch (SqlException SE)
            {
                MessageBox.Show(SE.ToString());
            }
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

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

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Course01 curs1 = new Course01();
            curs1.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int CourseID = int.Parse(bunifuMaterialTextbox1.Text);
            string CourseCode = bunifuMaterialTextbox4.Text;
            string CourseName = bunifuMaterialTextbox2.Text;
            string NoOfCredits = bunifuMaterialTextbox8.Text;
            string NoOfUnits = bunifuMaterialTextbox10.Text;
            float CourseFee = float.Parse(bunifuMaterialTextbox11.Text);
            int LecturerID = int.Parse(bunifuMaterialTextbox9.Text);
            string LecturerName = bunifuMaterialTextbox7.Text;
            string Description = bunifuMaterialTextbox5.Text;

            string qry = "INSERT INTO Course Values (" + CourseID + ",'" + CourseCode + "','" + CourseName + "','" + NoOfCredits + "','" + NoOfUnits + "'," + CourseFee + "," + LecturerID + ",'" + LecturerName + "', '"+Description+"')";

            DBConnection dbc = new DBConnection();
            string feedback = dbc.DBCon(qry);

            MessageBox.Show(feedback);
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Project\WindowsFormsApp1\DatabaseCP.mdf;Integrated Security=True");
            con.Open();

            if (bunifuMaterialTextbox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("SELECT CourseID, CourseCode, CourseName, NoOfCredits, NoOfUnits, CourseFee, LecturerID, LecturerName, Description where CourseID = @CourseID", con);

                cmd.Parameters.AddWithValue("@CourseID", int.Parse(bunifuMaterialTextbox1.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    bunifuMaterialTextbox4.Text = da.GetValue(1).ToString();
                    bunifuMaterialTextbox2.Text = da.GetValue(2).ToString();

                    bunifuMaterialTextbox8.Text = da.GetValue(3).ToString();
                    bunifuMaterialTextbox10.Text = da.GetValue(4).ToString();
                    bunifuMaterialTextbox11.Text = da.GetValue(5).ToString();
                    bunifuMaterialTextbox9.Text = da.GetValue(6).ToString();
                    bunifuMaterialTextbox7.Text = da.GetValue(7).ToString();
                    bunifuMaterialTextbox5.Text = da.GetValue(8).ToString();

                }
                con.Close();

            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            int CourseID = int.Parse(bunifuMaterialTextbox1.Text);
            string CourseCode = bunifuMaterialTextbox4.Text;
            string CourseName = bunifuMaterialTextbox2.Text;
            string NoOfCredits = bunifuMaterialTextbox8.Text;
            string NoOfUnits = bunifuMaterialTextbox10.Text;
            float CourseFee = float.Parse(bunifuMaterialTextbox11.Text);
            int LecturerID = int.Parse(bunifuMaterialTextbox9.Text);
            string LecturerName = bunifuMaterialTextbox7.Text;
            string Description = bunifuMaterialTextbox5.Text;

            string qry = "UPDATE Course SET CourseCode='" + CourseCode + "',CourseName='" + CourseName + "',NoOfCredits='" + NoOfCredits + "',NoOfUnits='" + NoOfUnits + "',CourseFee=" + CourseFee + ",LecturerID=" + LecturerID + ", LecturerName='" + LecturerName + "',Descriptio='" + Description + "', WHERE CourseID =" + CourseID + "  ";

            DBConnection dbc = new DBConnection();
            string feedback = dbc.DBCon(qry);

            MessageBox.Show(feedback);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox4.Text = "";
            bunifuMaterialTextbox8.Text = "";
            bunifuMaterialTextbox9.Text = "";
            bunifuMaterialTextbox5.Text = "";
            bunifuMaterialTextbox6.Text = "";
            bunifuMaterialTextbox2.Text = "";
            bunifuMaterialTextbox11.Text = "";
            bunifuMaterialTextbox10.Text = "";
            bunifuMaterialTextbox7.Text = "";
            bunifuMaterialTextbox5.Text = "";
            bunifuMaterialTextbox6.Text = "";
        }
    }
}
