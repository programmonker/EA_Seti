namespace lab3
{
    partial class Form2
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
            ipTextBox = new TextBox();
            usernameTextBox = new TextBox();
            submittButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // portTextBox
            // 
            ipTextBox.Location = new Point(132, 37);
            ipTextBox.Name = "portTextBox";
            ipTextBox.Size = new Size(100, 23);
            ipTextBox.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(132, 103);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(100, 23);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // submittButton
            // 
            submittButton.Location = new Point(12, 194);
            submittButton.Name = "submittButton";
            submittButton.Size = new Size(86, 23);
            submittButton.TabIndex = 2;
            submittButton.Text = "Подтвердить";
            submittButton.UseVisualStyleBackColor = true;
            submittButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите ip сервера:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 4;
            label2.Text = "Введите никнейм: ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 229);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(submittButton);
            Controls.Add(usernameTextBox);
            Controls.Add(ipTextBox);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ipTextBox;
        private TextBox usernameTextBox;
        private Button submittButton;
        private Label label1;
        private Label label2;
    }
}