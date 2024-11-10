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

namespace LibraryManagementSytem
{
    public partial class BookCheckinForm : Form
    {
        private const decimal FineRate = 5.00m;
        private string checkinConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\Champa BIT\ICT Project Final for submission\DesktopApplication\LibraryManagementSytem\LibraryManagementSytem\LMSdatabase.mdf;Integrated Security=True";
        public BookCheckinForm()
        {
            InitializeComponent();
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            string bookCode = txtBookID.Text;
            if (string.IsNullOrWhiteSpace(bookCode))
            {
                MessageBox.Show("Invalid Book Code.");
                return;
            }

            using (SqlConnection checkinConnection = new SqlConnection(checkinConnectionString))
            {
                checkinConnection.Open();

                // Check if the book exists
                string getBookQuery = "SELECT book_Id FROM [BookRecordTable] WHERE book_Id = @bookCode";
                SqlCommand getBookCommand = new SqlCommand(getBookQuery, checkinConnection);
                getBookCommand.Parameters.AddWithValue("@bookCode", bookCode);
                SqlDataReader bookReader =getBookCommand.ExecuteReader();

                if (!bookReader.HasRows)
                {
                    MessageBox.Show("Book does not exist.");
                    return;
                }

                bookReader.Read();
                int bookId = bookReader.GetInt32(0);
                bookReader.Close();

                // Get the transaction details
                string getTransactionQuery = "SELECT Transaction_Id, MemberID, DueDate FROM [TransactionTable] WHERE BookID = @bookId AND ReturnDate IS NULL";
                SqlCommand getTransactionCommand = new SqlCommand(getTransactionQuery, checkinConnection);
                getTransactionCommand.Parameters.AddWithValue("@bookId", bookId);
                SqlDataReader transactionReader = getTransactionCommand.ExecuteReader();

                if (!transactionReader.HasRows)
                {
                    MessageBox.Show("No active transaction found for this book.");
                    return;
                }

                transactionReader.Read();
                int transactionId = transactionReader.GetInt32(0);
                int memberId = transactionReader.GetInt32(1);
                DateTime dueDate = transactionReader.GetDateTime(2);
                transactionReader.Close();

                DateTime returnDate = DateTime.Now;
                decimal fineAmount = 0;

                // Calculate fine if return date is later than due date
                if (returnDate > dueDate)
                {
                    TimeSpan delayedDays = returnDate - dueDate;
                    fineAmount = (decimal)delayedDays.TotalDays * FineRate;
                }

                // Begin transaction to ensure atomicity
                using (SqlTransaction transaction = checkinConnection.BeginTransaction())
                {
                    try
                    {
                        // Update the transaction record with return date and fine amount
                        string updateTransactionQuery = "UPDATE [TransactionTable] SET ReturnDate = @returnDate, FineAmount = @fineAmount WHERE Transaction_Id = @transactionId";
                        SqlCommand updateTransactionCmd = new SqlCommand(updateTransactionQuery, checkinConnection, transaction);
                        updateTransactionCmd.Parameters.AddWithValue("@returnDate", returnDate);
                        updateTransactionCmd.Parameters.AddWithValue("@fineAmount", fineAmount);
                        updateTransactionCmd.Parameters.AddWithValue("@transactionId", transactionId);
                        updateTransactionCmd.ExecuteNonQuery();

                        // Update the book's availability
                        SqlCommand updateBookCmd = new SqlCommand("UPDATE [BookRecordTable] SET Is_available = 1 WHERE book_Id = @bookId", checkinConnection, transaction);
                        updateBookCmd.Parameters.AddWithValue("@bookId", bookId);
                        updateBookCmd.ExecuteNonQuery();

                        // Update the member's no_of_books_issued
                        SqlCommand updateMemberCmd = new SqlCommand("UPDATE [MemberRecord_Table] SET no_of_books_issued = no_of_books_issued - 1 WHERE mem_Id = @memberId", checkinConnection, transaction);
                        updateMemberCmd.Parameters.AddWithValue("@memberId", memberId);
                        updateMemberCmd.ExecuteNonQuery();

                        // Commit the transaction
                        transaction.Commit();

                        MessageBox.Show("Book checked in successfully. Fine Amount: " + fineAmount.ToString("C"));
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction if there is an error
                        transaction.Rollback();
                        MessageBox.Show("Error during check-in: " + ex.Message);
                    }
                }
            }

        }

        private void buttonFineSettle_Click(object sender, EventArgs e)
        {
            string bookCode = txtBookID.Text;
            if (string.IsNullOrWhiteSpace(bookCode))
            {
                MessageBox.Show("Invalid Book Code.");
                return;
            }

            using (SqlConnection checkinConnection = new SqlConnection(checkinConnectionString))
            {
                checkinConnection.Open();

                // Get the book_id
                SqlCommand getBookCmd = new SqlCommand("SELECT book_Id FROM [BookRecordTable] WHERE book_Id = @bookCode", checkinConnection);
                getBookCmd.Parameters.AddWithValue("@bookCode", bookCode);
                int bookId = (int)getBookCmd.ExecuteScalar();

                // Get the transaction details
                SqlCommand getTransactionCmd = new SqlCommand("SELECT Transaction_Id, FineAmount FROM [TransactionTable] WHERE BookID = @bookId AND FineAmount > 0", checkinConnection);
                getTransactionCmd.Parameters.AddWithValue("@bookId", bookId);
                SqlDataReader transactionReader = getTransactionCmd.ExecuteReader();

                if (!transactionReader.HasRows)
                {
                    MessageBox.Show("No outstanding fines found for this book.");
                    transactionReader.Close();
                    return;
                }

                transactionReader.Read();
                int transactionId = transactionReader.GetInt32(0);
                decimal fineAmount = transactionReader.GetDecimal(1);
                transactionReader.Close();

                // Begin transaction 
                using (SqlTransaction transaction = checkinConnection.BeginTransaction())
                {
                    try
                    {
                        // Delete the transaction record
                        SqlCommand deleteTransactionCmd = new SqlCommand("DELETE FROM [TransactionTable] WHERE Transaction_Id = @transactionId", checkinConnection, transaction);
                        deleteTransactionCmd.Parameters.AddWithValue("@transactionId", transactionId);
                        deleteTransactionCmd.ExecuteNonQuery();

                        // Commit the transaction
                        transaction.Commit();

                        MessageBox.Show("Fine settled and transaction record deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction if there is an error
                        transaction.Rollback();
                        MessageBox.Show("Error during fine settlement: " + ex.Message);
                    }
                }
            }
        }

        private void buttonReturnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePageForm homePage = new HomePageForm();
            homePage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you");
        }
    }
}
