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
            inputBox.Location = new Point(12, 444);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(415, 38);
            inputBox.TabIndex = 5;
            inputBox.Text = "";
            inputBox.KeyDown += inputBox_KeyDown;
            // 
            // historyBox
            // 
            historyBox.Location = new Point(12, 12);
            historyBox.Name = "historyBox";
            historyBox.ReadOnly = true;
            historyBox.Size = new Size(415, 426);
            historyBox.TabIndex = 7;
            historyBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 529);
            Controls.Add(historyBox);
            Controls.Add(inputBox);
            Controls.Add(sendButton);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button sendButton;
        private RichTextBox inputBox;
        private RichTextBox historyBox;
    }
}
