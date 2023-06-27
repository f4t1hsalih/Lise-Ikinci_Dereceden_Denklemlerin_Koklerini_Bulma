using System;
using System.Windows.Forms;

namespace Ikinci_Dereceden_Denklemlerin_Koklerini_Bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double d = (b * b) - (4 * a * c);

            if (d > 0)
            {
                double ilkkök = (-b - Math.Sqrt(d)) / (2 * a);
                double ikincikök = (-b + Math.Sqrt(d)) / (2 * a);
                label7.Text = ilkkök.ToString();
                label8.Text = ikincikök.ToString();
            }
            else if (d == 0)
            {
                double tekkök = -b / (2 * a);
                MessageBox.Show("Denklemin Bir Kökü Vardır = " + tekkök);
                label9.Text = tekkök.ToString();
            }
            else
                MessageBox.Show("Sanal Kök Vardır");
        }
    }
}

