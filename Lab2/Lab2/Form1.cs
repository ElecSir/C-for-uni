using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addSubscriptionButton_Click(object sender, EventArgs e)
        {
            var form = new SubscriptionForm();
            if (form.ShowDialog() == DialogResult.OK && form.Subscription != null)
            {
                AppContext.Subscriptions.Add(form.Subscription);
            }

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var form = new UserForm();
            if (form.ShowDialog() == DialogResult.OK && form.User != null)
            {
                AppContext.Users.Add(form.User);
            }

        }

        private void subscriptionsButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            foreach (var sub in AppContext.Subscriptions)
            {
                sb.AppendLine(sub.GetSubscriptionDetails());
            }

            outputTextBox.Text = sb.ToString();

        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            foreach (var user in AppContext.Users)
            {
                sb.AppendLine(user.GetUserDetails());
            }

            outputTextBox.Text = sb.ToString();
        }

        private void removeSubscriptionButton_Click(object sender, EventArgs e)
        {
            var form = new SubscriptionRemoveForm();
            form.ShowDialog();
        }
    }
}
