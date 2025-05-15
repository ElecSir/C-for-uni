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
    public partial class SubscriptionForm : Form
    {
        public int NAME_MAX_LENGTH = 200;
        public Subscription Subscription { get; private set; }
        public SubscriptionForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            if (name.Length > NAME_MAX_LENGTH)
            {
                MessageBox.Show($"Имя не должно быть больше {NAME_MAX_LENGTH} символов");
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите хотя бы один символ в названии");
                return;
            }

            var price = (double)priceNumeric.Value;
            DateTime startDate = StartDateTimePicker.Value;
            DateTime endDate = EndDateTimePicker.Value;
            if(startDate > endDate)
            {
                MessageBox.Show("Подписка не должна заканчиваться раньше чем началась");
                return;
            }

            var user = usersComboBox.SelectedItem as User;
            if (user == null)
            {
                MessageBox.Show("Необходимо выбрать пользователя!");
                return;
            }

            Subscription = new Subscription(Guid.NewGuid().ToString(), name, startDate, endDate, price, user);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void SubscriptionForm_Load(object sender, EventArgs e)
        {
            usersComboBox.Items.AddRange(AppContext.Users.ToArray());
            if (AppContext.Users == null || AppContext.Users.Count == 0)
            {
                MessageBox.Show("В начале создайте пользователя!");
                Close();
                return;
            }
        }

    }
}

