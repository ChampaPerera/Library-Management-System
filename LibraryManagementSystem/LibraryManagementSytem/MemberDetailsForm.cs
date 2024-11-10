using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSytem
{
    public partial class MemberDetailsForm : Form
    {
        private string memberRecordConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\Champa BIT\ICT Project Final for submission\DesktopApplication\LibraryManagementSytem\LibraryManagementSytem\LMSdatabase.mdf;Integrated Security=True";

        public MemberDetailsForm()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void BttnEdit_Click(object sender, EventArgs e)
        {

            string mem_id = textMemId.Text.Trim();
            string name = textMemName.Text.Trim();
            string date_of_membership = textMemDate.Text.Trim();
            string date_of_birth = textMemBDate.Text.Trim();
            string address = textAddress.Text.Trim();
            string phone_no = textPhoneNo.Text.Trim();
            string no_of_books_issued = textNoOfBooks.Text.Trim();
            int no_of_books = 0;
            DateTime dateMembership, dateBirth;

            if (string.IsNullOrEmpty(mem_id))
            {
                MessageBox.Show("Please enter a Member ID.");
                return;
            }


            // Validate Date of Membership
            if (!string.IsNullOrEmpty(date_of_membership) &&
                !DateTime.TryParseExact(date_of_membership, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateMembership))
            {
                MessageBox.Show("Invalid date format for Date of Membership. Please enter date in MM/dd/yyyy format.");
                return;
            }

            // Validate Date of Birth
            if (!string.IsNullOrEmpty(date_of_birth) &&
                !DateTime.TryParseExact(date_of_birth, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateBirth))
            {
                MessageBox.Show("Invalid date format for Date of Birth. Please enter date in MM/dd/yyyy format.");
                return;
            }



            using (SqlConnection memberRecordConnection = new SqlConnection(memberRecordConnectionString))
            {
                try
                {
                    memberRecordConnection.Open();

                    // Retrieve and display the book record
                    string query = "SELECT * FROM [MemberRecord_Table] WHERE mem_Id = @MemID";
                    SqlCommand command = new SqlCommand(query, memberRecordConnection);
                    command.Parameters.AddWithValue("@MemID", mem_id);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No membr record found with the provided Member ID.");
                        textMemId.Clear();
                    }
                    else
                    {

                        List<string> updateFields = new List<string>();
                        if (!string.IsNullOrEmpty(name))
                        {
                            updateFields.Add("name = @name");
                        }
                        if (!string.IsNullOrEmpty(date_of_membership))
                        {
                            updateFields.Add("date_of_membeship = @date_of_membership");
                        }
                        if (!string.IsNullOrEmpty(date_of_birth))
                        {
                            updateFields.Add("date_of_birth = @dob");
                        }
                        if (!string.IsNullOrEmpty(address))
                        {
                            updateFields.Add("address = @address");
                        }
                        if (!string.IsNullOrEmpty(phone_no))
                        {
                            updateFields.Add("phone_no = @phone_no");
                        }
                        if (!string.IsNullOrEmpty(no_of_books_issued))
                        {
                            updateFields.Add("no_of_books_issued = @no_of_books_issued");
                        }


                        string updateFieldsString = string.Join(", ", updateFields);
                        //string queryUpdate = "UPDATE [BookRecordTable] SET title = @title, author = @author, subject = @subject, isbn_no = @isbn, edition = @edition, language = @language, price = @price WHERE book_Id = @BookID ";

                        string queryUpdate = $"UPDATE [MemberRecord_Table] SET {updateFieldsString} WHERE mem_Id = @MemID";
                        SqlCommand commandUpdate = new SqlCommand(queryUpdate, memberRecordConnection);

                        commandUpdate.Parameters.AddWithValue("@MemID", mem_id);
                        commandUpdate.Parameters.AddWithValue("@name", name);
                        commandUpdate.Parameters.AddWithValue("@date_of_membership", date_of_membership);
                        commandUpdate.Parameters.AddWithValue("@dob", date_of_birth);
                        commandUpdate.Parameters.AddWithValue("@address", address);
                        commandUpdate.Parameters.AddWithValue("@phone_no", phone_no);
                        commandUpdate.Parameters.AddWithValue("@no_of_books_issued", no_of_books);


                        //commandUpdate.ExecuteNonQuery();
                        int rowsUpdated = commandUpdate.ExecuteNonQuery();

                        if (rowsUpdated > 0)
                        {
                            // Reload the data in the DataGridView
                            //LoadBookRecords();
                            MessageBox.Show("Member details updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Clear the input fields after successful insertion
                            textMemId.Clear();
                            textMemName.Clear();
                            textMemDate.Clear();
                            textAddress.Clear();
                            textPhoneNo.Clear();
                            textNoOfBooks.Clear();
                            textMemBDate.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Error occurred while updating the book record.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BttnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageForm home = new HomePageForm();
            home.Show();
        }

        private void BttnAddNew_Click(object sender, EventArgs e)
        {


            string name = textMemName.Text.Trim();
            string date_of_membership = textMemDate.Text.Trim();
            string date_of_birth = textMemBDate.Text.Trim();
            string address = textAddress.Text.Trim();
            string phone_no = textPhoneNo.Text.Trim();
            string no_of_books_issued = textNoOfBooks.Text.Trim();
            int no_of_books = 0;
            DateTime dateMembership, dateBirth;


            // Validate Date of Membership
            if (!string.IsNullOrEmpty(date_of_membership) &&
                !DateTime.TryParseExact(date_of_membership, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateMembership))
            {
                MessageBox.Show("Invalid date format for Date of Membership. Please enter date in MM/dd/yyyy format.");
                return;
            }

            // Validate Date of Birth
            if (!string.IsNullOrEmpty(date_of_birth) &&
                !DateTime.TryParseExact(date_of_birth, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateBirth))
            {
                MessageBox.Show("Invalid date format for Date of Birth. Please enter date in MM/dd/yyyy format.");
                return;
            }



            using (SqlConnection memberRecordConnection = new SqlConnection(memberRecordConnectionString))
            {
                try
                {
                    memberRecordConnection.Open();

                    string addNewQuery = "INSERT INTO [MemberRecord_Table] ( date_of_membeship, name, date_of_birth, address, phone_no, no_of_books_issued) " +
                                    "VALUES ( @date_of_membership, @name, @dob, @address, @phone_no, @no_of_books_issued)";
                    SqlCommand commandAddNew = new SqlCommand(addNewQuery, memberRecordConnection);



                    commandAddNew.Parameters.AddWithValue("@name", name);
                    commandAddNew.Parameters.AddWithValue("@date_of_membership", date_of_membership);
                    commandAddNew.Parameters.AddWithValue("@dob", date_of_birth);
                    commandAddNew.Parameters.AddWithValue("@address", address);
                    commandAddNew.Parameters.AddWithValue("@phone_no", phone_no);
                    commandAddNew.Parameters.AddWithValue("@no_of_books_issued", no_of_books);


                    //commandUpdate.ExecuteNonQuery();
                    int rowsAffected = commandAddNew.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Reload the data in the DataGridView
                        //LoadBookRecords();
                        MessageBox.Show("Member details added to the database successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Clear the input fields after successful insertion
                        textMemId.Clear();
                        textMemName.Clear();
                        textMemDate.Clear();
                        textMemBDate.Clear();
                        textAddress.Clear();
                        textPhoneNo.Clear();
                        textNoOfBooks.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Error occurred while inserting data to  the member record.");
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void BttnDelete_Click(object sender, EventArgs e)
        {

            string mem_ID = txtBoxMemberId.Text.Trim();

            if (string.IsNullOrEmpty(mem_ID))
            {
                MessageBox.Show("Please enter a member ID.");
                return;
            }

            using (SqlConnection memberRecordConnection = new SqlConnection(memberRecordConnectionString))

            {
                try
                {
                    memberRecordConnection.Open();

                    // Retrieve and display the book record
                    string deletQuery = "SELECT * FROM [MemberRecord_Table] WHERE mem_Id = @MemID";
                    SqlCommand deleteCommand = new SqlCommand(deletQuery, memberRecordConnection);
                    deleteCommand.Parameters.AddWithValue("@MemID", mem_ID);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(deleteCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No book record found with the provided Member ID.");
                        dataGridViewMem.DataSource = null;
                        txtBoxMemberId.Clear();
                    }
                    else
                    {

                        dataGridViewMem.DataSource = dataTable;

                        // Confirm deletion
                        var confirmResult = MessageBox.Show("Are you sure to delete this book record?",
                                                            "Confirm Delete",
                                                            MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            string query = "DELETE FROM [MemberRecord_Table] WHERE mem_Id = @MemID";
                            SqlCommand command = new SqlCommand(query, memberRecordConnection);
                            command.Parameters.AddWithValue("@MemID", mem_ID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Member record deleted successfully.");
                                dataGridViewMem.DataSource = null;
                                txtBoxMemberId.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Error occurred while deleting the member record.");
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void BttnView_Click(object sender, EventArgs e)
        {
            string mem_ID = txtBoxMemberId.Text.Trim();

            if (string.IsNullOrEmpty(mem_ID))
            {
                MessageBox.Show("Please enter a member ID.");
                return;
            }

            using (SqlConnection memberRecordConnection = new SqlConnection(memberRecordConnectionString))

            {
                try
                {
                    memberRecordConnection.Open();

                    // Retrieve and display the book record
                    string viewQuery = "SELECT * FROM [MemberRecord_Table] WHERE mem_Id = @MemID";
                    SqlCommand viewCommand = new SqlCommand(viewQuery, memberRecordConnection);
                    viewCommand.Parameters.AddWithValue("@MemID", mem_ID);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(viewCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No book record found with the provided Book ID.");
                        dataGridViewMem.DataSource = null;
                        txtBoxMemberId.Clear();
                    }
                    else
                    {

                        dataGridViewMem.DataSource = dataTable;

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void BttnReset_Click(object sender, EventArgs e)
        {
            dataGridViewMem.DataSource = null;
            txtBoxMemberId.Clear();
        }

        private void MemberDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSdatabaseDataSet3.BookRecordTable' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'lMSdatabaseDataSet2.MemberRecord_Table' table. You can move, or remove it, as needed.
            //this.memberRecord_TableTableAdapter.Fill(this.lMSdatabaseDataSet2.MemberRecord_Table);

        }
    }
}
