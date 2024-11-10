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
    public partial class BookCheckoutForm : Form
    {
        private string checkoutConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\Champa BIT\ICT Project Final for submission\DesktopApplication\LibraryManagementSytem\LibraryManagementSytem\LMSdatabase.mdf;Integrated Security=True";
        public BookCheckoutForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            int memberId;
            if (!int.TryParse(txtMemberId.Text, out memberId))
            {
                MessageBox.Show("Invalid Member ID.");
                return;
            }

            string bookCode = txtBookId.Text;
            if (string.IsNullOrWhiteSpace(bookCode))
            {
                MessageBox.Show("Invalid Book Code.");
                return;
            }
            try
            {
                using (SqlConnection checkoutConnection = new SqlConnection(checkoutConnectionString))
                {
                    checkoutConnection.Open();

                    // Check if the member exists and get the no_of_books_issued value
                    string checkMemberQuery = "SELECT no_of_books_issued FROM MemberRecord_Table WHERE mem_Id = @memberId";
                    SqlCommand checkMemberCmd = new SqlCommand(checkMemberQuery, checkoutConnection);
                    checkMemberCmd.Parameters.AddWithValue("@memberId", memberId);
                    SqlDataReader memberReader = checkMemberCmd.ExecuteReader();

                    if (!memberReader.HasRows)
                    {
                        MessageBox.Show("Member does not exist.");
                        return;
                    }

                    memberReader.Read();
                    int noOfBooksIssued = memberReader.GetInt32(0);
                    memberReader.Close();

                    if (noOfBooksIssued >= 2)
                    {
                        MessageBox.Show("Member has already issued the maximum number of books.");
                        return;
                    }

                    // Check if the book exists and is available
                    string getBookQuery = "SELECT book_Id, Is_available FROM BookRecordTable WHERE book_Id = @bookCode";
                    SqlCommand getBookCmd = new SqlCommand(getBookQuery, checkoutConnection);
                    getBookCmd.Parameters.AddWithValue("@bookCode", bookCode);
                    SqlDataReader bookReader = getBookCmd.ExecuteReader();

                    if (!bookReader.HasRows)
                    {
                        MessageBox.Show("Book does not exist.");
                        return;
                    }

                    bookReader.Read();
                    int bookId = bookReader.GetInt32(0);
                    bool available = bookReader.GetBoolean(1);
                    bookReader.Close();

                    if (!available)
                    {
                        MessageBox.Show("Book is not available.");
                        return;
                    }

                    // Begin transaction 
                    using (SqlTransaction transaction = checkoutConnection.BeginTransaction())
                    {
                        try
                        {
                            // Insert the transaction record
                            string insertTransactionQuery = "INSERT INTO [TransactionTable] (BookID, MemberID, CheckoutDate, DueDate) VALUES (@bookId, @memberId, @checkoutDate, @dueDate)";
                            SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionQuery, checkoutConnection, transaction);
                            insertTransactionCmd.Parameters.AddWithValue("@bookId", bookId);
                            insertTransactionCmd.Parameters.AddWithValue("@memberId", memberId);
                            insertTransactionCmd.Parameters.AddWithValue("@checkoutDate", DateTime.Now);
                            insertTransactionCmd.Parameters.AddWithValue("@dueDate", DateTime.Now.AddDays(14));
                            insertTransactionCmd.ExecuteNonQuery();

                            // Update the book's availability
                            string updateBookQuery = "UPDATE BookRecordTable SET Is_available = 0 WHERE book_Id = @bookId";
                            SqlCommand updateBookCmd = new SqlCommand(updateBookQuery, checkoutConnection, transaction);
                            updateBookCmd.Parameters.AddWithValue("@bookId", bookId);
                            updateBookCmd.ExecuteNonQuery();

                            // Update the member's no_of_books_issued
                            string updateMemberQuery = "UPDATE MemberRecord_Table SET no_of_books_issued = no_of_books_issued + 1 WHERE mem_Id = @memberId";
                            SqlCommand updateMemberCmd = new SqlCommand(updateMemberQuery, checkoutConnection, transaction);
                            updateMemberCmd.Parameters.AddWithValue("@memberId", memberId);
                            updateMemberCmd.ExecuteNonQuery();

                            // Commit the transaction
                            transaction.Commit();

                            MessageBox.Show("Book checked out successfully.");
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction if there is an error
                            transaction.Rollback();
                            MessageBox.Show("Error during checkout: " + ex.Message);
                        }
                    }
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

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageForm homePage = new HomePageForm();
            homePage.Show();
        }
    }
}
