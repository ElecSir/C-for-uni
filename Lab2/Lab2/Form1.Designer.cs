
namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addSubscriptionButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.subscriptionsButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeSubscriptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addSubscriptionButton
            // 
            this.addSubscriptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addSubscriptionButton.Location = new System.Drawing.Point(578, 33);
            this.addSubscriptionButton.Name = "addSubscriptionButton";
            this.addSubscriptionButton.Size = new System.Drawing.Size(180, 60);
            this.addSubscriptionButton.TabIndex = 0;
            this.addSubscriptionButton.Text = "Добавить подписку";
            this.addSubscriptionButton.UseVisualStyleBackColor = true;
            this.addSubscriptionButton.Click += new System.EventHandler(this.addSubscriptionButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserButton.Location = new System.Drawing.Point(578, 109);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(180, 60);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Добавить пользователя";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // subscriptionsButton
            // 
            this.subscriptionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.subscriptionsButton.Location = new System.Drawing.Point(578, 279);
            this.subscriptionsButton.Name = "subscriptionsButton";
            this.subscriptionsButton.Size = new System.Drawing.Size(180, 60);
            this.subscriptionsButton.TabIndex = 2;
            this.subscriptionsButton.Text = "Список подписок";
            this.subscriptionsButton.UseVisualStyleBackColor = true;
            this.subscriptionsButton.Click += new System.EventHandler(this.subscriptionsButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.usersButton.Location = new System.Drawing.Point(578, 355);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(180, 60);
            this.usersButton.TabIndex = 3;
            this.usersButton.Text = "Список пользователей";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 33);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(528, 382);
            this.outputTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Окно вывода";
            // 
            // removeSubscriptionButton
            // 
            this.removeSubscriptionButton.Location = new System.Drawing.Point(578, 190);
            this.removeSubscriptionButton.Name = "removeSubscriptionButton";
            this.removeSubscriptionButton.Size = new System.Drawing.Size(180, 60);
            this.removeSubscriptionButton.TabIndex = 6;
            this.removeSubscriptionButton.Text = "Удалить подписку";
            this.removeSubscriptionButton.UseVisualStyleBackColor = true;
            this.removeSubscriptionButton.Click += new System.EventHandler(this.removeSubscriptionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 459);
            this.Controls.Add(this.removeSubscriptionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.subscriptionsButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.addSubscriptionButton);
            this.Name = "Form1";
            this.Text = "Стерхов С.Л. Б24-171-1 вариант 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSubscriptionButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button subscriptionsButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeSubscriptionButton;
    }
}

