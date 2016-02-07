using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViVa
{
    public partial class Form1 : Form
    {
        bool isPg = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isPg = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isPg==true)
            {
                comboBox1.DisplayMember = "WSN";
                comboBox1.DisplayMember = "ACNW";
            }
            else
            {
                comboBox1.DisplayMember = "DS";
                comboBox1.DisplayMember = "DBS";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isPg = false;
        }
    }
}
