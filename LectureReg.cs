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
    public partial class LectureReg : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Project\WindowsFormsApp1\DatabaseCP.mdf;Integrated Security=True");
        public LectureReg()
        {
            InitializeComponent();
        }

        public void ID()
        {
            try
            {
                string ID;
                string query = "select ID from Lecturer order by ID Desc";
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

                bunifuMaterialTextbox12.Text = ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuMaterialTextbox14_OnValueChanged(object sender, EventArgs e)
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
            Lectures01 LeC = new Lectures01();
            LeC.Show();
            this.Hide();

        }

        void dropDown(bool show)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(bunifuMaterialTextbox12.Text);
            string Name = bunifuMaterialTextbox1.Text;
            string NIC = bunifuMaterialTextbox10.Text;
            
            string DOBDate = Convert.ToString(bunifuDropdown1.selectedIndex + 1);

            string DOBMonth = "";
            if (bunifuDropdown2.selectedIndex == 0)
            {
                DOBMonth = "January";
            }
            else if (bunifuDropdown2.selectedIndex == 1)
            {
                DOBMonth = "February";
            }
            else if (bunifuDropdown2.selectedIndex == 2)
            {
                DOBMonth = "March";
            }
            else if (bunifuDropdown2.selectedIndex == 3)
            {
                DOBMonth = "April";
            }
            else if (bunifuDropdown2.selectedIndex == 4)
            {
                DOBMonth = "May";
            }
            else if (bunifuDropdown2.selectedIndex == 5)
            {
                DOBMonth = "June";
            }
            else if (bunifuDropdown2.selectedIndex == 6)
            {
                DOBMonth = "July";
            }
            else if (bunifuDropdown2.selectedIndex == 7)
            {
                DOBMonth = "August";
            }
            else if (bunifuDropdown2.selectedIndex == 8)
            {
                DOBMonth = "September";
            }
            else if (bunifuDropdown2.selectedIndex == 9)
            {
                DOBMonth = "October";
            }
            else if (bunifuDropdown2.selectedIndex == 10)
            {
                DOBMonth = "November";
            }
            else
            {
                DOBMonth = "December";
            }

            string DOBYear = Convert.ToString(2020 - bunifuDropdown3.selectedIndex + 1);
            string MobileNumber = bunifuMaterialTextbox4.Text;
            string EmailAddress = bunifuMaterialTextbox3.Text;
            string Address = bunifuMaterialTextbox5.Text;
            string AcademicQualifications = bunifuMaterialTextbox11.Text;
            string ProfessionalQualifications = bunifuMaterialTextbox13.Text;

            string qry = "INSERT INTO Lecturer Values (" + ID + ",'" + Name + "','" + NIC + "','" + DOBDate + "','" + DOBMonth + "','" + DOBYear + "','" + MobileNumber + "','" + EmailAddress + "','" + Address + "','" + AcademicQualifications + "','" + ProfessionalQualifications + "')";
            DBConnection dbc = new DBConnection();
            string feedback = dbc.DBCon(qry);

            MessageBox.Show(feedback);
        }

        private void LectureReg_Load(object sender, EventArgs e)
        {
            ID();

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

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(bunifuMaterialTextbox12.Text);
            string Name = bunifuMaterialTextbox1.Text;
            string NIC = bunifuMaterialTextbox10.Text;

            string DOBDate = Convert.ToString(bunifuDropdown1.selectedIndex + 1);

            string DOBMonth = "";
            if (bunifuDropdown2.selectedIndex == 0)
            {
                DOBMonth = "January";
            }
            else if (bunifuDropdown2.selectedIndex == 1)
            {
                DOBMonth = "February";
            }
            else if (bunifuDropdown2.selectedIndex == 2)
            {
                DOBMonth = "March";
            }
            else if (bunifuDropdown2.selectedIndex == 3)
            {
                DOBMonth = "April";
            }
            else if (bunifuDropdown2.selectedIndex == 4)
            {
                DOBMonth = "May";
            }
            else if (bunifuDropdown2.selectedIndex == 5)
            {
                DOBMonth = "June";
            }
            else if (bunifuDropdown2.selectedIndex == 6)
            {
                DOBMonth = "July";
            }
            else if (bunifuDropdown2.selectedIndex == 7)
            {
                DOBMonth = "August";
            }
            else if (bunifuDropdown2.selectedIndex == 8)
            {
                DOBMonth = "September";
            }
            else if (bunifuDropdown2.selectedIndex == 9)
            {
                DOBMonth = "October";
            }
            else if (bunifuDropdown2.selectedIndex == 10)
            {
                DOBMonth = "November";
            }
            else
            {
                DOBMonth = "December";
            }

            string DOBYear = Convert.ToString(2020 - bunifuDropdown3.selectedIndex + 1);
            string MobileNumber = bunifuMaterialTextbox4.Text;
            string EmailAddress = bunifuMaterialTextbox3.Text;
            string Address = bunifuMaterialTextbox5.Text;
            string AcademicQualifications = bunifuMaterialTextbox11.Text;
            string ProfessionalQualifications = bunifuMaterialTextbox13.Text;

            string qry = "UPDATE Lecturer SET Name='" + Name + "',NIC='" + NIC + "',DOBDate='" + DOBDate + "',DOBMonth='" + DOBMonth + "',DOBYear='" + DOBYear + "',MobileNumber='" + MobileNumber + "',EmailAddress='" + EmailAddress + "',Address='" + Address + "',AcadamicQualifications='" + AcademicQualifications + "',ProfessionalQualification='" + ProfessionalQualifications + "' WHERE ID = " + ID + " ";
            DBConnection dbc = new DBConnection();
            string feedback = dbc.DBCon(qry);

            MessageBox.Show(feedback);
        }
    


        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Project\WindowsFormsApp1\DatabaseCP.mdf;Integrated Security=True");
                con.Open();

                if (bunifuMaterialTextbox12.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("SELECT ID, Name, NIC, DOBDate, DOBMonth, DOBYear, MobileNumber, EmailAddress, Address, AcademicQualifications, ProfessionalQualifications where ID = @ID", con);

                    cmd.Parameters.AddWithValue("@ID", int.Parse(bunifuMaterialTextbox12.Text));
                    SqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        bunifuMaterialTextbox1.Text = da.GetValue(1).ToString();
                        bunifuMaterialTextbox10.Text = da.GetValue(2).ToString();

                   // bunifuMaterialTextbox4.Text = da.GetValue(3).ToString();   DOBDate
                   // bunifuMaterialTextbox4.Text = da.GetValue(4).ToString();  DOBMonth
                   // bunifuMaterialTextbox4.Text = da.GetValue(5).ToString();  DOBYear

                        bunifuMaterialTextbox4.Text = da.GetValue(6).ToString();
                        bunifuMaterialTextbox3.Text = da.GetValue(7).ToString();
                        bunifuMaterialTextbox5.Text = da.GetValue(8).ToString();
                        bunifuMaterialTextbox11.Text = da.GetValue(9).ToString();
                        bunifuMaterialTextbox13.Text = da.GetValue(10).ToString();
                        
                    }
                    con.Close();
                
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
