using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_View
{
    public partial class InputForm2 : Form
    {
        public string name;
        public int n1;
        public int n2;
        public int year;

        public InputForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            n1 = int.Parse(textBox2.Text);
            n2 = int.Parse(textBox3.Text);
            year = int.Parse(textBox4.Text);
            this.Close();
        }
    }
}
