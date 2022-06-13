using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_Model;

namespace _2_View
{
    public partial class Form1 : Form
    {
        Performance performance;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Спектакль с годом написания?", "Вопрос",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                InputForm1 f1 = new InputForm1();
                f1.Owner = this;
                f1.ShowDialog();
                performance = new Performance(f1.name, f1.n1, f1.n2);
            }
            else
            {
                InputForm2 f2 = new InputForm2();
                f2.Owner = this;
                f2.ShowDialog();
                performance = new PerformanceYear(f2.name, f2.n1, f2.n2, f2.year);
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(performance.getInfo() +
                "\nКачество спектакля: " + performance.getQuality());
        }
    }
}
