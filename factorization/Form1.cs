using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace edu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Gray;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi = Convert.ToDouble(textBox1.Text);
                for (int i = 0; i <= sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
                textBox1.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show("it's not a number","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox1.Text = null;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = null;
        }
    }
}

