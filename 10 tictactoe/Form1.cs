using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string zn = "X";
        string bt;
        string bn;
        char bln;
        bool C4V;
        int wo=0;
        int wk=0;
        List <String> pon = new List<String>();
        List <String> pok = new List<String>();
        List <String> bl = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bt = (sender as Button).Text;
            //pon.Insert(0, (sender as Button).Name);
            
            if (bt == "")
            {
                if (zn == "X")
                {
                    zn = "O";
                    if (pon.Count > 2 && pon[2] != null)
                    {
                        this.Controls.Find(pon.ElementAt(2), true).FirstOrDefault().Text = "";
                    }
                    (sender as Button).Text = zn;
                    pon.Insert(0, (sender as Button).Name);
                }
                else
                {
                    zn = "X";
                    if (pok.Count > 2 && pok[2] != null)
                    {
                        this.Controls.Find(pok.ElementAt(2), true).FirstOrDefault().Text = "";
                    }
                    (sender as Button).Text = zn;
                    pok.Insert(0, (sender as Button).Name);
                }
                bn = (sender as Button).Name;
                bln = bn[bn.Length-1];
                bl.Clear();
                C4V = false;
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        Button button = c as Button;
                        bl.Add(button.Text);
                    }
                }
                for (int i = 0; i < 3; i++)
                    {
                    if (bl[i] == zn)
                        {
                        if (bl[i] == bl[i + 3] && bl[i] == bl[i + 6] && bl[i] != "") C4V = true; // vert
                        if (bl[i] == bl[4] && bl[i] == bl[8 - i] && bl[i] != "") C4V = true; // diag
                        }// 2 3 8 bl[i * 3] == zn
                    if (bl[i * 3] == zn && bl[i * 3] == bl[i * 3 + 1] && bl[i * 3] == bl[i * 3 + 2] && bl[i * 3] != "") C4V = true; // horiz
                    }
                if (C4V == true)
                {
                    int chs=0;
                    foreach (Control c in this.Controls)
                    {
                        if (c is Button)
                        {
                            Button button = c as Button;
                            //this.Controls.Remove(button);
                            button.Text = "";
                        }
                    }
                    if (zn == "O") wo += 1;
                    else wk += 1;
                    label1.Text = zn + " Won " + (zn == "O" ? wo.ToString() : wk.ToString()) + " times!!!";
                }
                //if (button1.Text == button2.Text && button1.Text == button3.Text || button1.Text == button5.Text && button1.Text == button9.Text || button1.Text == button4.Text && button1.Text == button7.Text || button2.Text == button5.Text && button2.Text == button8.Text || button3.Text == button6.Text && button3.Text == button9.Text || button3.Text == button6.Text && button3.Text == button9.Text)
            }
        }
    }
}
