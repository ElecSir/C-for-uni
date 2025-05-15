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
    public partial class UserForm : Form
    {
        public int NAME_MAX_LENGTH = 200;
        public User User { get; private set; }

        public UserForm()
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
                MessageBox.Show($"Введите хотя бы один символ в имени");
                return;
            }

            var email = emailTextBox.Text;
            if (!email.Contains("@"))
            {
                MessageBox.Show($"Неверный адрес эл. почты");
                return;
            }

            User = new User(Guid.NewGuid().ToString(), name, email);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
