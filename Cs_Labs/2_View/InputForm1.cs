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
    public partial class InputForm1 : Form
    {
        public string name;
        public int n1;
        public int n2;
        public InputForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            n1 = int.Parse(textBox2.Text);
            n2 = int.Parse(textBox3.Text);
            this.Close();
        }
    }
}
