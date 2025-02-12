namespace lab1
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
            decodeButton = new Button();
            label1 = new Label();
            label2 = new Label();
            inputBox = new RichTextBox();
            outputBox = new RichTextBox();
            historyBox = new RichTextBox();
            SuspendLayout();
            // 
            // encodeButton
            // 
            encodeButton.Location = new Point(320, 43);
            encodeButton.Name = "encodeButton";
            encodeButton.Size = new Size(75, 23);
            encodeButton.TabIndex = 0;
            encodeButton.Text = "button1";
            encodeButton.UseVisualStyleBackColor = true;
            encodeButton.Click += encodeButton_Click;
            // 
            // decodeButton
            // 
            decodeButton.Location = new Point(320, 95);
            decodeButton.Name = "decodeButton";
            decodeButton.Size = new Size(75, 23);
            decodeButton.TabIndex = 1;
            decodeButton.Text = "button2";
            decodeButton.UseVisualStyleBackColor = true;
            decodeButton.Click += decodeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 3);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // inputBox
            // 
            inputBox.Location = new Point(12, 21);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(302, 190);
            inputBox.TabIndex = 5;
            inputBox.Text = "";
            // 
            // outputBox
            // 
            outputBox.Location = new Point(401, 21);
            outputBox.Name = "outputBox";
            outputBox.ReadOnly = true;
            outputBox.Size = new Size(302, 190);
            outputBox.TabIndex = 6;
            outputBox.Text = "";
            // 
            // historyBox
            // 
            historyBox.Location = new Point(12, 248);
            historyBox.Name = "historyBox";
            historyBox.Size = new Size(710, 190);
            historyBox.TabIndex = 7;
            historyBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 450);
            Controls.Add(historyBox);
            Controls.Add(outputBox);
            Controls.Add(inputBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(decodeButton);
            Controls.Add(encodeButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button encodeButton;
        private Button decodeButton;
        private Label label1;
        private Label label2;
        private RichTextBox inputBox;
        private RichTextBox outputBox;
        private RichTextBox historyBox;
    }
}
