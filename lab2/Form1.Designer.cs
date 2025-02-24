namespace lab2
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
            encodeButton = new Button();
            inputBox = new RichTextBox();
            historyBox = new RichTextBox();
            portTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // encodeButton
            // 
            encodeButton.Location = new Point(322, 488);
            encodeButton.Name = "encodeButton";
            encodeButton.Size = new Size(105, 23);
            encodeButton.TabIndex = 0;
            encodeButton.Text = "Закодировать";
            encodeButton.UseVisualStyleBackColor = true;
            encodeButton.Click += encodeButton_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 529);
            Controls.Add(label1);
            Controls.Add(portTextBox);
            Controls.Add(historyBox);
            Controls.Add(inputBox);
            Controls.Add(encodeButton);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button encodeButton;
        private RichTextBox inputBox;
        private RichTextBox historyBox;
        private TextBox portTextBox;
        private Label label1;
    }
}
