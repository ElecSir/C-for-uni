
namespace Lab2
{
    partial class SubscriptionRemoveForm
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
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subscriptionsComboBox = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersComboBox
            // 
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(12, 29);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(215, 21);
            this.usersComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите пользоваля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите подписку";
            // 
            // subscriptionsComboBox
            // 
            this.subscriptionsComboBox.FormattingEnabled = true;
            this.subscriptionsComboBox.Location = new System.Drawing.Point(12, 74);
            this.subscriptionsComboBox.Name = "subscriptionsComboBox";
            this.subscriptionsComboBox.Size = new System.Drawing.Size(215, 21);
            this.subscriptionsComboBox.TabIndex = 3;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(12, 110);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(215, 23);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Удалить";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // SubscriptionRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 156);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.subscriptionsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersComboBox);
            this.Name = "SubscriptionRemoveForm";
            this.Text = "Удаление подписки";
            this.Load += new System.EventHandler(this.SubscriptionRemoveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox subscriptionsComboBox;
        private System.Windows.Forms.Button confirmButton;
    }
}