using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentReg
{
    public partial class Form1 : Form
    {
        string name = string.Empty;
        string email = string.Empty;
        string dept = string.Empty;
        long rollno=0;
        char gen;
        string dob = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   //if()
            if (!email.Contains("@"))
            {
                MessageBox.Show("Error Email invalid");
            }
            if (!email.Contains(".com"))
            {
                MessageBox.Show("Error Email invalid");
            }
            if (name.Contains("1") || name.Contains("2") || name.Contains("3") || name.Contains("4") || name.Contains("5") || name.Contains("6") || name.Contains("7") || name.Contains("8") || name.Contains("9") || name.Contains("0"))
            {
                MessageBox.Show("Invalid name");
            }
            if (!Char.IsDigit(rollno))
            {

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = this.textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            email = this.textBox3.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string r = this.textBox2.Text;
            long.TryParse(r, out rollno);
        }
    }
}
