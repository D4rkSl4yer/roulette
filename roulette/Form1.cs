using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace roulette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int Credits = 3000;
        private static List<field> fields = new List<field>();
        private void Form1_Load(object sender, EventArgs e)
        {
            var sr = new StreamReader(@"french_layout.txt");
            fields.Add(new field(sr.ReadLine()));
            while (sr.EndOfStream)
            {
                string[] dbok = sr.ReadLine().Split(';');
                fields.Add(new field(dbok[0]));
                fields.Add(new field(dbok[1]));
                fields.Add(new field(dbok[2]));
            }
            Credit_l.Text = Credits.ToString();
            for (int i = 0; i < fields.Count; i++)
            {
                this.Controls["button" + i.ToString()].ForeColor = Color.White;
                if (fields[i].col == 'G')
                {
                    this.Controls["button" + i.ToString()].BackColor = Color.Green;
                    this.Controls["button" + i.ToString()].Text = fields[i].num.ToString();
                }
                else if (fields[i].col == 'R')
                {
                    this.Controls["button" + i.ToString()].Text = fields[i].num.ToString();
                    this.Controls["button" + i.ToString()].BackColor = Color.Red;
                }
                else
                {
                    this.Controls["button" + i.ToString()].Text = fields[i].num.ToString();
                    this.Controls["button" + i.ToString()].BackColor = Color.Black;
                }

            }
        }
        private void buttonBlack_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void buttonEven_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button_play_Click(object sender, EventArgs e)
        {
            if (Credits >= int.Parse(textBox1.Text))
            {
                if (marked_l.Text != "-")
                {
                    Credits -= int.Parse(textBox1.Text);
                    Random rnd = new Random();
                    label_rollednum.Text = rnd.Next(0, 37).ToString();
                    if (marked_l.Text == label_rollednum.Text)
                    {
                        Credits += int.Parse(textBox1.Text) * 35;
                    }
                    else if (marked_l.Text == "Odd")
                    {
                        if (double.Parse(label_rollednum.Text) % 2 != 0)
                        {
                            Credits += int.Parse(textBox1.Text) * 2;
                        }
                    }
                    else if (marked_l.Text == "Even")
                    {
                        if (double.Parse(label_rollednum.Text) % 2 == 0)
                        {
                            Credits += int.Parse(textBox1.Text) * 2;
                        }
                    }
                    else if (marked_l.Text == "B")
                    {
                        for (int i = 0; i < fields.Count; i++)
                        {
                            if (fields[i].num == int.Parse(marked_l.Text))
                            {
                                if (fields[i].col == 'B')
                                {
                                    Credits += int.Parse(textBox1.Text) * 2;
                                }
                            }
                        }
                    }
                    else if (marked_l.Text == "R")
                    {
                        for (int i = 0; i < fields.Count; i++)
                        {
                            if (fields[i].num == int.Parse(marked_l.Text))
                            {
                                if (fields[i].col == 'R')
                                {
                                    Credits += int.Parse(textBox1.Text) * 2;
                                }
                            }
                        }
                    }
                    Credit_l.Text = Credits.ToString();
                }
                else
                {
                    MessageBox.Show("insufficient bet");
                }
            }
            else
            {
                MessageBox.Show("insufficient bet");
            }
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void buttonOdd_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button0_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button23_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button25_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button26_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button27_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button28_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button29_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button30_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button31_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button32_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button33_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button34_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button35_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        private void button36_Click(object sender, EventArgs e)
        {
            marked_l.Text = this.Text;

        }

        
    }
}
