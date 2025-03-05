using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022300042
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] value = new int[2];
        private int satu;
        private int dua;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            satu = 1;
                label1.Text = "1";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            satu = 4;
            label1.Text = "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            satu = 3;
            label1.Text = "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            satu = 9;
            label1.Text = "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            satu = 3;
            label1.Text = "3";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            dua = satu;
            satu = 0;
            label1.Text = "0"; 
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            int hasil = satu + dua; 
            label1.Text = Convert.ToString(hasil);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            satu = 2;
            label1.Text = "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            satu = 5;
            label1.Text = "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            satu = 7;
            label1.Text = "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            satu = 8;
            label1.Text = "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            satu = 0;
            label1.Text = "0";
        }
    }
}
