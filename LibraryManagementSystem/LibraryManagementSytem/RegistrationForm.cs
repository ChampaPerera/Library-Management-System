using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagementSytem
{
    public partial class RegistrationForm : Form
    {
        private string registrationConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\Champa BIT\ICT Project Final for submission\DesktopApplication\LibraryManagementSytem\LibraryManagementSytem\LMSdatabase.mdf;Integrated Security=True";

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string confirmedpassword = textBoxCnofirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(username)) 
            {
                MessageBox.Show("Please enter a username.");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }
            if (string.IsNullOrEmpty(confirmedpassword))
            {
                MessageBox.Show("Pleaseconfirm the password.");
                return;
            }
            if(confirmedpassword != password)
            {
                MessageBox.Show("Password does not match.");
                return;
            }

            using (SqlConnection registerConnection = new SqlConnection(registrationConnectionString))
            {
                try
                {
                    registerConnection.Open();

                    string query = "INSERT INTO [Login Table] (username, password) VALUES (@username, @password)";
                    SqlCommand command = new SqlCommand(query, registerConnection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        
                        MessageBox.Show("New user registered successfully.");
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.ShowDialog();
                        // Clear the input fields after successful insertion
                        textBoxUsername.Clear();
                        textBoxPassword.Clear();
                        textBoxCnofirmPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error occurred while adding the new book.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();  
            loginForm.ShowDialog();
        }
    }
}
