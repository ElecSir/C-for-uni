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
    public partial class SubscriptionRemoveForm : Form
    {
        public SubscriptionRemoveForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Subscription selectedSub = subscriptionsComboBox.SelectedItem as Subscription;
            if (selectedSub == null)
            {
                MessageBox.Show("Выберите подписку!");
                return;
            }

            AppContext.Subscriptions.Remove(selectedSub);
            MessageBox.Show($"Подписка {selectedSub} удалена");
            Close();
        }

        private void SubscriptionRemoveForm_Load(object sender, EventArgs e)
        {
            usersComboBox.Items.AddRange(AppContext.Users.ToArray());
            if (AppContext.Users == null || AppContext.Users.Count == 0 || AppContext.Subscriptions == null || AppContext.Subscriptions.Count == 0)
            {
                MessageBox.Show("В начале создайте пользователя и подписки!");
                Close();
                return;
            }     

            usersComboBox.SelectedIndexChanged += UsersComboBox_SelectedIndexChanged;
        }

        private void UsersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subscriptionsComboBox.Items.Clear();
            if (usersComboBox.SelectedItem == null) return;

            User selectedUser = usersComboBox.SelectedItem as User;
            foreach (Subscription subscription in AppContext.Subscriptions)
            {
                if (subscription.User.UserID == selectedUser.UserID)
                {
                    subscriptionsComboBox.Items.Add(subscription);
                }
            }
        }
    }
}
