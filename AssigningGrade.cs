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
    public partial class AssigningGrade : Form
    {
        public AssigningGrade()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
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

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Exam01 Ex1 = new Exam01();
            Ex1.Show();
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Project\WindowsFormsApp1\DatabaseCP.mdf;Integrated Security=True");
            con.Open();

            if (bunifuMaterialTextbox3.Text != "")
            {
                SqlCommand cmd = new SqlCommand("SELECT ID, Name, Degree, Year, Semester from Student where ID = @ID", con);

                cmd.Parameters.AddWithValue("@ID", int.Parse(bunifuMaterialTextbox3.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    bunifuMaterialTextbox1.Text = da.GetValue(1).ToString();
                    bunifuMaterialTextbox2.Text = da.GetValue(2).ToString();
                    string years = da.GetValue(3).ToString();
                    string sem = da.GetValue(4).ToString();
                    int yearNum = 0, semNum = 0;

                    if(years == "Year 1              ")
                    {
                        yearNum = 0;
                    }
                    else if(years == "Year 2              ")
                    {
                        yearNum = 1;
                    }
                    else if(years == "Year 3              ")
                    {
                        yearNum = 2;

                    }
                    else
                    {
                        yearNum = 3;
                    }

                    if(sem == "Semester 01         ")
                    {
                        semNum = 0;
                    }
                    else if(sem == "Semester 02         ")
                    {
                        semNum = 1;
                    }
                    else
                    {
                        semNum = 2;
                    }

                    bunifuDropdown3.selectedIndex = yearNum;
                    bunifuDropdown1.selectedIndex = semNum;
                }
                con.Close();

            }

            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Project\WindowsFormsApp1\DatabaseCP.mdf;Integrated Security=True");
            con.Open();

            if (bunifuMaterialTextbox3.Text != "")
            {
                SqlCommand cmd2 = new SqlCommand("SELECT Subject1, Subject2, Subject3, Subject4 from Subjects where StudentID = @StudentID", con);
                cmd2.Parameters.AddWithValue("@StudentID", int.Parse(bunifuMaterialTextbox3.Text));
                SqlDataReader da2 = cmd2.ExecuteReader();
                while (da2.Read())
                {
                    bunifuMaterialTextbox12.Text = da2.GetValue(0).ToString();
                    bunifuMaterialTextbox4.Text = da2.GetValue(1).ToString();
                    bunifuMaterialTextbox5.Text = da2.GetValue(2).ToString();
                    bunifuMaterialTextbox6.Text = da2.GetValue(3).ToString();
                }
            }

            con2.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(bunifuMaterialTextbox3.Text);
            string Subject1 = bunifuMaterialTextbox12.Text;
            string Subject2 = bunifuMaterialTextbox4.Text;
            string Subject3 = bunifuMaterialTextbox5.Text;
            string Subject4 = bunifuMaterialTextbox6.Text;

            string qry = "INSERT INTO Subjects Values ("+ID+",'" +Subject1+ "','" + Subject2 + "','" + Subject3 + "','" + Subject4 + "')";
            DBConnection dbc = new DBConnection();
            string feedback = dbc.DBCon(qry);

            MessageBox.Show(feedback);

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

            int StudentID = int.Parse(bunifuMaterialTextbox3.Text);
            string Subject1 = bunifuMaterialTextbox12.Text;
            string Grade1 = bunifuMaterialTextbox7.Text;
            string Subject2 = bunifuMaterialTextbox4.Text;
            string Grade2 = bunifuMaterialTextbox8.Text;
            string Subject3 = bunifuMaterialTextbox5.Text;
            string Grade3 = bunifuMaterialTextbox9.Text;
            string Subject4 = bunifuMaterialTextbox6.Text;
            string Grade4 = bunifuMaterialTextbox10.Text;

            string qry = "INSERT INTO Examination Values (" + StudentID + ",'" + Subject1 + "','" + Grade1 + "','" + Subject2 + "','" + Grade2 + "','" + Subject3 + "','" + Grade3 + "','" + Subject4 + "', '"+Grade4+"')";
            DBConnection dbc = new DBConnection();
            string feedback = dbc.DBCon(qry);

            MessageBox.Show(feedback);

        }

        private void AssigningGrade_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox3.Text = "";
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
            bunifuMaterialTextbox12.Text = "";
            bunifuMaterialTextbox7.Text = "";
            bunifuMaterialTextbox4.Text = "";
            bunifuMaterialTextbox8.Text = "";
            bunifuMaterialTextbox5.Text = "";
            bunifuMaterialTextbox9.Text = "";
            bunifuMaterialTextbox6.Text = "";
            bunifuMaterialTextbox10.Text = "";
        }
    }
}
