﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEPROJECTS
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Dark");
            if (comboBox1.SelectedIndex == 0)
            {
                Form8 fn = new Form8();
                this.Hide();
                fn.Show();
            }
            comboBox1.Items.Add("CyberForce");
            if (comboBox1.SelectedIndex == 1)
            {
                Form9 fn = new Form9();
                this.Hide();
                fn.Show();
            }
            comboBox1.Items.Add("The Ripple");
            if (comboBox1.SelectedIndex == 2)
            {
                Form11 fn = new Form11();
                this.Hide();
                fn.Show();
            }
            comboBox1.Items.Add("Into The Woods");
            if (comboBox1.SelectedIndex == 3)
            {
                Form10 fn = new Form10();
                this.Hide();
                fn.Show();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            Form13 f3 = new Form13();
            this.Hide();
            f3.Show();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 fn = new Form14();
            this.Hide();
            fn.Show();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            Form13 fn = new Form13();
            this.Hide();
            fn.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            Form6 fn = new Form6();
            this.Hide();
            fn.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Form2 fn = new Form2();
            this.Hide();
            fn.Show();

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
