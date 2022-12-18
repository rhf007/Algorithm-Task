using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insertion_Sort_Task
{
    public partial class Form1 : Form
    {
        public int n1;
        public int n2;
        public int n3;
        public int n4;
        public int n5;
        public int n6;
        public int n7;
        public int n8;
        public int n9;
        public int n10;
        public int n11;
        public int n12;
        public int n13;
        public int n14;
        public int n15;
        int[] buffer = new int[15];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(T1.Text);
            n2 = int.Parse(T2.Text);
            n3 = int.Parse(T3.Text);
            n4 = int.Parse(T4.Text);
            n5 = int.Parse(T5.Text);
            n6 = int.Parse(T6.Text);
            n7 = int.Parse(T7.Text);
            n8 = int.Parse(T8.Text);
            n9 = int.Parse(T9.Text);
            n10 = int.Parse(T10.Text);
            n11 = int.Parse(T11.Text);
            n12 = int.Parse(T12.Text);
            n13 = int.Parse(T13.Text);
            n14 = int.Parse(T14.Text);
            n15 = int.Parse(T15.Text);
            buffer = new int[] {n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15};

            for (int i = 1; i < buffer.Length; i++)
            {
                int key = buffer[i];
                int j = i - 1;
                while (j >= 0 && buffer[j] > key)
                {
                    buffer[j + 1] = buffer[j];
                    j--;
                }
                buffer[j + 1] = key;
            }

            string srt_bfr = string.Join(", ", buffer);
            label4.Text = srt_bfr;
        }

        private void label3_Click(object sender, EventArgs e)
        {






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Clear(buffer, 0, buffer.Length);
            T1.Text = String.Empty;
            T2.Text = String.Empty;
            T3.Text = String.Empty;
            T4.Text = String.Empty;
            T5.Text = String.Empty;
            T6.Text = String.Empty;
            T7.Text = String.Empty;
            T8.Text = String.Empty;
            T9.Text = String.Empty;
            T10.Text = String.Empty;
            T11.Text = String.Empty;
            T12.Text = String.Empty;
            T13.Text = String.Empty;
            T14.Text = String.Empty;
            T15.Text = String.Empty;
            label4.Text = "";
        }
    }
}
