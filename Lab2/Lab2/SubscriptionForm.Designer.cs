
namespace Lab2
{
    partial class SubscriptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.confirmButton = new System.Windows.Forms.Button();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(240, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название подписки:";
            // 
            // priceNumeric
            // 
            this.priceNumeric.Location = new System.Drawing.Point(12, 68);
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(240, 20);
            this.priceNumeric.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена подписки";
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(12, 111);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(240, 20);
            this.StartDateTimePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата начала подписки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата окончания подписки";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(12, 155);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(240, 20);
            this.EndDateTimePicker.TabIndex = 7;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(12, 230);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(240, 23);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Принять";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // usersComboBox
            // 
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(12, 194);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(240, 21);
            this.usersComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пользователь";
            // 
            // SubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 265);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usersComboBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "SubscriptionForm";
            this.Text = "Параметры подписки";
            this.Load += new System.EventHandler(this.SubscriptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Label label5;
    }
}