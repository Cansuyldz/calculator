using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numarator(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
                textBox1.Text = "";
            var b = sender as Button;
            textBox1.Text += b.Text;
        }

        private void Virgül(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text += ",";
        }

        private void Fonksiyon(object sender, EventArgs e)
        {
            var b = sender as Button;
            double sonuc = 0;
            double sayi = double.Parse(textBox1.Text);
            switch (b.Text)
            {
                case "sin":
                    sonuc = Math.Sin(sayi*Math.PI/180);
                    break;
                case "cos":
                    sonuc = Math.Cos(sayi * Math.PI / 180);
                    break;
                case "tan":
                    sonuc = Math.Tan(sayi * Math.PI / 180);
                    break;
                case "ln":
                    sonuc = Math.Log(sayi);
                    break;
                case "log":
                    sonuc= Math.Log10(sayi);
                    break;
                case "exp":
                    sonuc = Math.Exp(sayi);
                    break;
                case "1/x":
                    sonuc = 1 / sayi;
                    break;
                case "x2":
                    sonuc = sayi * sayi;
                    break;
                case "kök":
                    sonuc = Math.Sqrt(sayi);
                    break;
                case "n!":
                    sonuc = 1;
                    for (int i = 0; i <= sayi; i++)
                        sonuc *= i;
                    break;
                case "pi":
                    sonuc = Math.PI;
                    break;
            }
            textBox1.Text = sonuc.ToString();
            label1.Text = b.Text + " " + sayi;

            if (b.Text == "1/x")
                label1.Text = "1/" + sayi;
            else if (b.Text == "n!")
                label1.Text = sayi + "!";
            else if (b.Text == "x2")
                label1.Text = sayi + "²";
            else if (b.Text == "pi")
                label1.Text = b.Text;

        }
        double sayi1;
        string op;
        private void Operator(object sender, EventArgs e)
        {
            var b = sender as Button;
            sayi1 = double.Parse(textBox1.Text);
            op = b.Text;

            textBox1.Text = "0";
            label1.Text = sayi1 + " " + op;

        }

        private void SonucHesapla(object sender, EventArgs e)
        {
            var sayi2 = double.Parse(textBox1.Text);
            double sonuc = 0;

            switch (op)
            {
                case "+":
                    sayi1 += sayi2;
                    break;
                    case "-":
                    sayi1 -= sayi2;
                    break;
                case "*":
                    sayi1 *= sayi2;
                    break;
                case "/":
                    sayi1 /= sayi2;
                    break;
                case "mod":
                    sayi1 %= sayi2;
                    break;
                case "x^y":
                    sayi1 = Math.Pow(sayi1, sayi2);
                    break;
            }
            textBox1.Text = sayi1.ToString();
            label1.Text += " " +  sayi2.ToString();
        }

        private void Temizle(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            sayi1 = 0;
            label1.Text = "";

        }

        private void BirBasamakSil(object sender, EventArgs e)
        {
            if(textBox1.Text.Length >0)
                textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length - 1);

            if (textBox1.Text == "")
                textBox1.Text = "0";
        }
    }
}
