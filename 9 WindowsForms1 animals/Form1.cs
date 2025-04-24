using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1_animals
{
    public partial class Form1 : Form
    {
        string txt;
        public Form1()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("animals.txt", Encoding.Default))
            {
                textBox1.Text = sr.ReadToEnd();
                txt = sr.ReadLine();
            }
            textBox1.AppendText(" \r\n Guess animal \r\n\r\n");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\r\n" + label1.Text + " - " + (sender as Button).Text + "\r\n");
            using (StreamReader sr = new StreamReader("animals.csv", Encoding.Default))
            {
                //sr.seek(0);
                //txt = ;
                string[] data, num;
                List<string> not = new List<string>();
                int t = 0;
                double tag, max = 0;
                data = sr.ReadLine().Split(';').ToArray();
                tag = Convert.ToDouble((sender as Button).Tag);
                //textBox1.AppendText(tag.ToString());
                for (int i=1; i < data.Length; i++)
                {
                    if (data[i] == label1.Text)
                        t = i;
                }
                for (int i = 0; i < 46; i++)
                {
                    num = sr.ReadLine().Split(';').ToArray();
                    double otv = Convert.ToDouble(num[t]);
                    if (num[t]!="" &&  Convert.ToDouble(num[t]) <= tag)
                    {
                        if (1 == otv)
                            max=num.IndexOf;
                    }
                    else
                    {
                        not.Add(num[0]);
                    }
                    textBox1.AppendText(num[0] + " " + num[t] + "\r\n");
                }
                label1.Text = data[t];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
