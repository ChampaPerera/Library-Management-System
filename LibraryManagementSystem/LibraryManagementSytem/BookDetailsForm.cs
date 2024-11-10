using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSytem
{
    
    public partial class BookDetailsForm : Form
    {
        private string bookRecordConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\Champa BIT\ICT Project Final for submission\DesktopApplication\LibraryManagementSytem\LibraryManagementSytem\LMSdatabase.mdf;Integrated Security=True";
        public BookDetailsForm()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
                string bookID = txtBookId.Text.Trim();

                if (string.IsNullOrEmpty(bookID))
                {
                    MessageBox.Show("Please enter a Book ID.");
                    return;
                }

                using (SqlConnection bookRecordConnection = new SqlConnection(bookRecordConnectionString))
            
                {
                try
                {
                    bookRecordConnection.Open();

                    // Retrieve and display the book record
                    string query = "SELECT * FROM [BookRecordTable] WHERE book_Id = @BookID";
                    SqlCommand command = new SqlCommand(query, bookRecordConnection);
                    command.Parameters.AddWithValue("@BookID", bookID);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No book record found with the provided Book ID.");
                        dataGridViewRecord.DataSource = null;
                        txtBookId.Clear();
                    }
                    else
                    {
                        
                        dataGridViewRecord.DataSource = dataTable;

                        // Confirm deletion
                        var confirmResult = MessageBox.Show("Are you sure to delete this book record?",
                                                            "Confirm Delete",
                                                            MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            query = "DELETE FROM [BookRecordTable] WHERE book_Id = @BookID";
                            command = new SqlCommand(query, bookRecordConnection);
                            command.Parameters.AddWithValue("@BookID", bookID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book record deleted successfully.");
                                dataGridViewRecord.DataSource = null;
                                txtBookId.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Error occurred while deleting the book record.");
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageForm home = new HomePageForm();
            home.ShowDialog();
        }

       /* private void dataGridViewRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string title = textTitle.Text.Trim();
            string author = textAuthor.Text.Trim();
            string subject = textSubject.Text.Trim();
            string isbnNo = textISBN.Text.Trim();
            string edition = textEdition.Text.Trim();
            string language = textLanguage.Text.Trim();
            string priceText = textPrice.Text.Trim();
            decimal price;

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Title is required.");
                return;
            }

            if (!decimal.TryParse(priceText, out price))
            {
                MessageBox.Show("Invalid price value.");
                return;
            }
            
            using (SqlConnection bookRecordconnection = new SqlConnection(bookRecordConnectionString))
            {
                try
                {
                    bookRecordconnection.Open();

                    string query = "INSERT INTO [BookRecordTable] (title, author, subject, isbn_no, Is_available, edition, language, price) " +
                                   "VALUES (@title, @author, @subject, @isbn, @isAvailable, @edition, @language, @price)";
                    SqlCommand command = new SqlCommand(query, bookRecordconnection);
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@author", author);
                    command.Parameters.AddWithValue("@subject", subject);
                    command.Parameters.AddWithValue("@isbn", isbnNo);
                    command.Parameters.AddWithValue("@isAvailable", true);
                    command.Parameters.AddWithValue("@edition", edition);
                    command.Parameters.AddWithValue("@language", language);
                    command.Parameters.AddWithValue("@price", price);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Reload the data in the DataGridView
                        LoadBookRecords();
                        MessageBox.Show("New book added successfully.");
                        // Clear the input fields after successful insertion
                        textTitle.Clear();
                        textAuthor.Clear();
                        textSubject.Clear();
                        textISBN.Clear();
                        textEdition.Clear();
                        textLanguage.Clear();
                        textPrice.Clear();

                        
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

        private void LoadBookRecords()
        {
            using (SqlConnection bookRecordConnection = new SqlConnection(bookRecordConnectionString))
            {
                try
                {
                    bookRecordConnection.Open();

                    // Query to retrieve the last added book record
                    string query = "SELECT TOP 1 * FROM [BookRecordTable] ORDER BY book_Id DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, bookRecordConnection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewRecord.DataSource = dataTable;
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

        private void BookDetailsForm_Load(object sender, EventArgs e)
        {
            //LoadBookRecords();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear text entries in all textboxes
            txtBookId.Clear();
            textTitle.Clear();
            textAuthor.Clear();
            textSubject.Clear();
            textISBN.Clear();
            textEdition.Clear();
            textLanguage.Clear();
            textPrice.Clear();

            // Clear DataGridView
            dataGridViewRecord.DataSource = null;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string title = textTitle.Text.Trim();
            string author = textAuthor.Text.Trim();
            string subject = textSubject.Text.Trim();
            string isbnNo = textISBN.Text.Trim();
            string edition = textEdition.Text.Trim();
            string language = textLanguage.Text.Trim();
            string priceText = textPrice.Text.Trim();
            decimal price =0.0m;
            string bookID = textBookId.Text.Trim();

            if (string.IsNullOrEmpty(bookID))
            {
                MessageBox.Show("Please enter a Book ID.");
                return;
            }
            if ((!string.IsNullOrEmpty(priceText))
                && (!decimal.TryParse(priceText, out price)))
            {
                MessageBox.Show("Invalid price value.");
                return;
            }
            using (SqlConnection bookRecordConnection = new SqlConnection(bookRecordConnectionString))
            {
                try
                {
                    bookRecordConnection.Open();

                    // Retrieve and display the book record
                    string query = "SELECT * FROM [BookRecordTable] WHERE book_Id = @BookID";
                    SqlCommand command = new SqlCommand(query, bookRecordConnection);
                    command.Parameters.AddWithValue("@BookID", bookID);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No book record found with the provided Book ID.");
                        textBookId.Clear();
                    }
                    else {

                        List<string> updateFields = new List<string>();
                        if (!string.IsNullOrEmpty(title))
                        {
                            updateFields.Add("title = @title");
                        }
                        if (!string.IsNullOrEmpty(author))
                        {
                            updateFields.Add("author = @author");
                        }
                        if (!string.IsNullOrEmpty(isbnNo))
                        {
                            updateFields.Add("isbn_no = @isbn");
                        }
                        if (!string.IsNullOrEmpty(subject))
                        {
                            updateFields.Add("subject = @subject");
                        }
                        if (!string.IsNullOrEmpty(edition))
                        {
                            updateFields.Add("edition = @edition");
                        }
                        if (!string.IsNullOrEmpty(language))
                        {
                            updateFields.Add("language = @language");
                        }
                        if (!string.IsNullOrEmpty(priceText))
                        {
                            updateFields.Add("price = @price");
                        }

                        string updateFieldsString = string.Join(", ", updateFields);
                        //string queryUpdate = "UPDATE [BookRecordTable] SET title = @title, author = @author, subject = @subject, isbn_no = @isbn, edition = @edition, language = @language, price = @price WHERE book_Id = @BookID ";
                       
                        string queryUpdate = $"UPDATE [BookRecordTable] SET {updateFieldsString} WHERE book_Id = @BookID";
                        SqlCommand commandUpdate = new SqlCommand(queryUpdate, bookRecordConnection);
                        
                        commandUpdate.Parameters.AddWithValue("@BookID", bookID);
                        commandUpdate.Parameters.AddWithValue("@title", title);
                        commandUpdate.Parameters.AddWithValue("@author", author);
                        commandUpdate.Parameters.AddWithValue("@isbn", isbnNo);
                        commandUpdate.Parameters.AddWithValue("@subject", subject);
                        commandUpdate.Parameters.AddWithValue("@edition", edition);
                        commandUpdate.Parameters.AddWithValue("@language", language);
                        commandUpdate.Parameters.AddWithValue("@price", price) ;
                        //commandUpdate.ExecuteNonQuery();
                        int rowsUpdated = commandUpdate.ExecuteNonQuery();

                        if (rowsUpdated > 0)
                        {
                            // Reload the data in the DataGridView
                            //LoadBookRecords();
                            MessageBox.Show("Book details updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Clear the input fields after successful insertion
                            textBookId.Clear();
                            textTitle.Clear();
                            textAuthor.Clear();
                            textISBN.Clear();
                            textSubject.Clear();
                            textEdition.Clear();
                            textLanguage.Clear();
                            textPrice.Clear();
                        }else 
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
    }
}
