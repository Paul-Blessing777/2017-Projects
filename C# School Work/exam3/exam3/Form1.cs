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

namespace exam3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int scores;
            int total = 0;
            int avg = 0;
            StreamWriter outputFile;
            outputFile = File.CreateText("scores.txt");
            outputFile.WriteLine(textBox1.Text);
            outputFile.WriteLine(textBox2.Text);
            outputFile.WriteLine(textBox3.Text);
            outputFile.WriteLine(textBox4.Text);
            outputFile.WriteLine(textBox5.Text);
            outputFile.Close();
        

            StreamReader inputFile;
            inputFile = File.OpenText("scores.txt");
            while (!inputFile.EndOfStream)
            {
                scores = int.Parse(inputFile.ReadLine());
                avg = scores / 5;
                total += scores;
                
            }
            inputFile.Close();
            avgLabel.Text = avg.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
