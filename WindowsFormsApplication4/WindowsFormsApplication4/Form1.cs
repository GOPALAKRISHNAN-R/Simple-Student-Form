using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rn = textBox1.Text;
            string name = textBox2.Text;
            string course = listBox1.Text;
            string year = listBox2.Text;
            string gn = "";
            string cn = "";
            string tit = "student";
  
                      if (radioButton1.Checked == true)
            {
                gn = radioButton1.Text;
            }
            else
            {
                gn = radioButton2.Text;
            }
            if (checkBox1.Checked == true)
            {
                cn = checkBox1.Text;
            }
            else
            {
                cn = checkBox2.Text;
            }
            MessageBox.Show("Register no.:" + rn + "\nStudent name:" + name + "\ncourse:" + course + "\nyear:" + year + "\nGender:" + gn + "\nContact:" + cn, "Student Information");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.Text = "";
            listBox2.Text = "";
            checkBox1.Checked =false ;
            checkBox2.Checked = false ;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
                    }

       
    }
}
