using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void Controler();
        Controler del;
        List<int> MyList = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Clear();
            MyList.Clear();
            Random rnd = new Random();
            int number = Int32.Parse(textBox1.Text);
            MyList.Capacity = number;

            
            for (int i=0; i<MyList.Capacity; i++)
            {
                MyList.Add(rnd.Next(1,10000));
                richTextBox2.AppendText(MyList[i].ToString()+'\n');
                richTextBox1.AppendText(MyList[i].ToString()+'\n');
            }
        } //Generation

        private void button4_Click(object sender, EventArgs e)
        {
            int min = MyList.Min(a=>a);
            MessageBox.Show("Min number is "+ min.ToString(),"Minimum");
                          
        } //min

        private void button2_Click(object sender, EventArgs e)
        {
            int max = MyList.Max(a => a);
            MessageBox.Show("Max number is "+ max.ToString(), "Maximum");
        } //max

        private void button3_Click(object sender, EventArgs e)
        {
            double average = MyList.Average(a => a);
            MessageBox.Show("Average is "+average.ToString(),"An average");
        } //average

        private void Sort_Down()
        {
            MyList.Sort();
            richTextBox1.Clear();
            for (int i = 0; i < MyList.Capacity; i++)
            {
                richTextBox1.AppendText(MyList[i].ToString() + '\n');
            }
        }

        private void Sort_Up()
        {
            MyList.Sort();
            MyList.Reverse();
            richTextBox2.Clear();
            for (int i = 0; i < MyList.Capacity; i++)
            {
                richTextBox2.AppendText(MyList[i].ToString() + '\n');
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            del=Sort_Down;
            del();
        } //down

        private void button6_Click(object sender, EventArgs e)
        {
            del = Sort_Up;
            del();
        } //up

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           if(Regex.IsMatch(textBox1.Text,"[^0-9]"))
            {
                MessageBox.Show("Enter only numbers");
                textBox1.Text = null;
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }
        
    }
}
