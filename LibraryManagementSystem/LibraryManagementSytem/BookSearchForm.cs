using System;
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
    public partial class BookSearchForm : Form
    {
        private string searchConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\Champa BIT\ICT Project Final for submission\DesktopApplication\LibraryManagementSytem\LibraryManagementSytem\LMSdatabase.mdf;Integrated Security=True";
        public BookSearchForm()
        {
            InitializeComponent();
        }

        private void BookSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSdatabaseDataSet.BookRecordTable' table. You can move, or remove it, as needed.
            //this.bookRecordTableTableAdapter.Fill(this.lMSdatabaseDataSet.BookRecordTable);
            // Fill the ComboBox with search options
            comboSearchOption.Items.AddRange(new string[] { "Author", "Title", "Subject", "BookID" });
            comboSearchOption.SelectedIndex = 0; // Default selection

            // Optionally load all records initially
            //LoadAllRecords();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchTerm.Text = string.Empty;
            //txtSearchTerm.Clear();
            bookDataGridView.DataSource = null; // Clear DataGridView
            bookDataGridView.Rows.Clear();
        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageForm home = new HomePageForm();
            home.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedOption = comboSearchOption.SelectedItem.ToString();
            string searchTerm = txtSearchTerm.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            string query = GetQuery(selectedOption, searchTerm);

            using (SqlConnection searchConnection = new SqlConnection(searchConnectionString))
            {
                try
                {
                    searchConnection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, searchConnection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found for the given search term.");
                    }
                    else
                    {
                        bookDataGridView.DataSource = dataTable;
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
        /*private void LoadAllRecords()
        {
            using (SqlConnection connection = new SqlConnection(searchConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [BookRecordTable]", connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    bookDataGridView.DataSource = dataTable;
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
        }*/

        private string GetQuery(string option, string term)
        {
            switch (option)
            {
                case "Author":
                    return $"SELECT * FROM [BookRecordTable] WHERE author LIKE '%{term}%'";
                case "Title":
                    return $"SELECT * FROM [BookRecordTable] WHERE title LIKE '%{term}%'";
                case "Subject":
                    return $"SELECT * FROM [BookRecordTable] WHERE subject LIKE '%{term}%'";
                case "BookID":
                    return $"SELECT * FROM [BookRecordTable] WHERE book_Id LIKE '%{term}%'";
                default:
                    throw new ArgumentException("Invalid search option.");
            }
        }
    }
}
