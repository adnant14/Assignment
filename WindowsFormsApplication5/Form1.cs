using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        //branch develop
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                label1.Text = "Enter Numbers";
            double count = 0, sum = 0, num;
            foreach (var s in textBox1.Text.Split(','))
            {
                if (double.TryParse(s, out num))
                {
                    count++;
                    sum += num;

                }
            }
            label1.Text = "" + sum / count;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
