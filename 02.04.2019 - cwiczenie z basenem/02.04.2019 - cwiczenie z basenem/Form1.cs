using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02._04._2019___cwiczenie_z_basenem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            String Poems = "";
            while (x > 1)
            { Poems = Poems + ""; }
            if (x < 1)
            {
                x = x + 1;
            }
            Poems = Poems + "a";
            if (x > 0)
            {
                x = x + 2;
            }
            Poems = Poems + " noise";
            if (x < 4)
            {
                x = x - 1;
            }
            Poems = Poems + " annoys ";
            if(x > 1)
            {
                x = x - 2;
            }
            Poems = Poems + "an ";
            if (x == 0)
            {
                x = x + 1;
            }
            Poems = Poems + "oyster";
        
            MessageBox.Show(Poems);
        }
    }
}
