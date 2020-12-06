using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Email_Validate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Text.RegularExpressions.Regex email = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-90]@[a-zA-Z09][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
        private void button1_Click(object sender, EventArgs e)
        {
            if (!email.IsMatch(textBox1.Text))
            {
                MessageBox.Show("Uneli ste neispravnu email adresu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.SelectAll();
               
            }
            else
                MessageBox.Show("Vasa email adresa je evidentirana","Hvala",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
