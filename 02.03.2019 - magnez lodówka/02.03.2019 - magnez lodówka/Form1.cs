using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02._03._2019___magnez_lodówka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Result = "";
            int x = 3;
            while (x > 1)
            {
                if (x > 2)
                {
                 Result = Result + "a";
                    x = x - 1;
                    Result = Result + "-";
                }                
                if (x == 2)
                {
                    Result = Result + " b c ";
                    x = x - 1;
                    Result = Result + "-"; 
                }
                if (x == 1)
                {
                    Result = Result + "d";
                    x = x - 1;
                }


                MessageBox.Show(Result);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dlugosc = Talker.BlahBlahBlah(textBox1.Text, (int)numericUpDown1.Value);
            MessageBox.Show("Długość wiadomości to: " + dlugosc);
        }
    }
}
