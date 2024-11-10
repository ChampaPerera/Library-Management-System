using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSytem
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookSearchForm bookSearch = new BookSearchForm();
            bookSearch.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookCheckoutForm check_out = new BookCheckoutForm();
            check_out.Show();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookCheckinForm check_in = new BookCheckinForm();
            check_in.Show();

        }

        private void btnBookManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookDetailsForm bookDetails = new BookDetailsForm();
            bookDetails.Show();
        }

        private void btnMemberManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemberDetailsForm memberDetails = new MemberDetailsForm();
            memberDetails.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
