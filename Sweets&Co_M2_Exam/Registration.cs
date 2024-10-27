using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Sweets_Co_M2_Exam
{
    public partial class Registration : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-UGA3M36S\SQLEXPRESS;Initial Catalog=loginData;Integrated Security=True;");

        public Registration()
        {
            InitializeComponent();
        }
        private void btnLoginHere_Click(object sender, EventArgs e)
        {
            frmLogin lForm = new frmLogin();
            lForm.Show();
            this.Hide();
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || txtAddress.Text == "" ||
                txtNumber.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM [loginData].[dbo].[loginTable] WHERE username = '" +
                            txtUsername.Text.Trim() + "'";

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(txtUsername.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                string insertData = "INSERT INTO [loginData].[dbo].[loginTable] (firstName, LastName, address, phoneNumber, userName, passWord, date)" +
                                    "VALUES(@FirstName, @LastName, @Address, @PhoneNumber, @UserName, @PassWord, @Date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PhoneNumber", txtNumber.Text.Trim());
                                    cmd.Parameters.AddWithValue("@UserName", txtUsername.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PassWord", txtPassword.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Date", date);



                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    frmLogin lForm = new frmLogin();
                                    lForm.Show();
                                    this.Hide();
                                }

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0' ;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
