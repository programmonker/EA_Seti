using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form2 : Form
    {
        string path;
        public Form2()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            path = $"{now}.txt".Replace(' ', '_').Replace(':', '-'); 
            using (StreamWriter writer = new StreamWriter(path, true)) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1(this, usernameTextBox.Text, path, ipTextBox.Text);
            newForm.Show();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

            usernameTextBox.Text = usernameTextBox.Text.Replace(" ", "");
        }
    }
}
