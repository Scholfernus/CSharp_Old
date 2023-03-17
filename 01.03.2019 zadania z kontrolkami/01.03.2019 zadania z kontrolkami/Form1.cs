using System;
using System.Drawing;
using System.Windows.Forms;

namespace _01._03._2019_zadania_z_kontrolkami
    {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
                label1.BackColor = Color.Green;
                MessageBox.Show("Pole wyboru jest zaznaczone");
            
                if (checkBox1.Checked == true)
            {
                textBox1.BackColor = Color.Yellow;
                button1.BackColor = Color.Tomato;
                label1.BackColor = Color.Orange;
            }            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (int i = 0; i <= 254 && Visible; i++)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(10);
                }
            }
            for (int i =254; i >= 0 && Visible; i--)
            {
                this.BackColor = Color.FromArgb(i, 255 - i, i);
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
            
        }
    }
}
