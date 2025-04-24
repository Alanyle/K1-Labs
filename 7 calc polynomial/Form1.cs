using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        List<int> p = new List<int>();
        List<double> k = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = (int)numericUpDown1.Value;
            double b = Convert.ToDouble(textBox1.Text);
            bool add =true;
            for (int i = 0; i < p.Count && add; i++)
                if (p[i] == a)
                {
                    k[i] += b;
                    add = false;
                }
                if (add)
                {
                    p.Add(a); 
                    k.Add(b);
                }

            for (int i = 0; i < p.Count-1; i++)
                for (int j = i+1; j < p.Count; j++)
                    if (p[i]<p[j])
                    {
                        int t = p[i];
                        p[i] = p[j];
                        p[j] = t;
                        double c = k[i];
                        k[i] = k[j];
                        k[j] = c;
                    }
            textBox2.Text += "P(x) = ";
            int q = 0;
            for (int i = 0; i < p.Count; i++){
                textBox2.Text += (q>0? (k[i]>0? " + ":""):"");
                if (k[i] != 0) {
                    if (k[i] != 1 && k[i] != -1 || p[i] == 0)
                    {
                        textBox2.Text +=k[i];
                        q++;
                    }
                    if (k[i] == -1 && p[i] != 0)
                    {
                        textBox2.Text += " -";
                        q++;
                    }

                    if (p[i] != 0)
                    {
                        textBox2.Text += "x";
                        q++;
                        if (p[i] != 1)
                            textBox2.Text += "^" + p[i];
                    }
                }
            }
            if (q == 0)
                textBox2.Text += q;
            textBox2.Text += "\r\n";
        }
    }
}