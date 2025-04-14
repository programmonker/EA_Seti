namespace lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sendButton = new Button();
            inputBox = new RichTextBox();
            historyBox = new RichTextBox();
            portTextBox = new TextBox();
            label1 = new Label();
            ipTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // sendButton
            // 
            sendButton.Location = new Point(322, 488);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(105, 23);
            sendButton.TabIndex = 0;
            sendButton.Text = "Отправить";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // inputBox
            // 
            inputBox.Location = new Point(146, 444);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(281, 38);
            inputBox.TabIndex = 5;
            inputBox.Text = "";
            // 
            // historyBox
            // 
            historyBox.Location = new Point(146, 12);
            historyBox.Name = "historyBox";
            historyBox.ReadOnly = true;
            historyBox.Size = new Size(281, 426);
            historyBox.TabIndex = 7;
            historyBox.Text = "";
            // 
            // portTextBox
            // 
            portTextBox.Location = new Point(12, 220);
            portTextBox.Name = "portTextBox";
            portTextBox.Size = new Size(100, 23);
            portTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 187);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 9;
            label1.Text = "Введите порт для \r\nотправки сообщений:";
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new Point(12, 296);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(100, 23);
            ipTextBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 263);
            label2.Name = "label2";
            label2.Size = new Size(129, 30);
            label2.TabIndex = 11;
            label2.Text = "Введите ip для \r\nотправки сообщений:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 529);
            Controls.Add(label2);
            Controls.Add(ipTextBox);
            Controls.Add(label1);
            Controls.Add(portTextBox);
            Controls.Add(historyBox);
            Controls.Add(inputBox);
            Controls.Add(sendButton);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendButton;
        private RichTextBox inputBox;
        private RichTextBox historyBox;
        private TextBox portTextBox;
        private Label label1;
        private TextBox ipTextBox;
        private Label label2;
    }
}
