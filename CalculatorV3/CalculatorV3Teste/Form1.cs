﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorV3Teste
{
    public partial class Form1 : Form
    {
        public double Resultado { get; set; }
        public double Valor { get; set; }

        private Operation selectedOperation {  get; set; }
        private enum Operation
        {
            Sum,
            Subtraction,
            Multiplication,
            Division,
            Potentiation,
            Radication,
            Logarithm,
            Factorial,
            Module,
            Notation
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void Notacao_Click(object sender, EventArgs e)
        {
            selectedOperation = Operation.Notation;
            if (textBox1.Text == "")
            {
                Valor = 10;
            }
            else
            {
                Valor = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = "";
            textBox1.Text = "";
            
            
            
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            switch (selectedOperation)
            {
                case Operation.Sum:
                    Resultado = Valor + Convert.ToDouble(textBox1.Text);
                    break;
                case Operation.Subtraction:
                    Resultado = Valor - Convert.ToDouble(textBox1.Text);
                    break;
                case Operation.Multiplication:
                    Resultado = Valor * Convert.ToDouble(textBox1.Text);
                    break;
                case Operation.Division:
                    Resultado = Valor / Convert.ToDouble(textBox1.Text);
                    break;
                case Operation.Notation:
                    Resultado = Math.Pow(10, Convert.ToDouble(textBox1.Text));
                    break;
                case Operation.Potentiation:
                    Resultado = Math.Pow(Convert.ToDouble(Valor), Convert.ToDouble(textBox1.Text));
                    break;
                case Operation.Factorial: 
                        if (textBox1.Text == "0" || textBox1.Text == "1")
                        Resultado = 1;

                    long results = 1;

                    for (int i = 1; i <= Convert.ToDouble(textBox1.Text); i++)
                    {
                        results *= i;
                    }

                    Resultado = results;

                    break;
                case Operation.Logarithm:
                    Resultado = Math.Log(Valor) / Math.Log(Convert.ToDouble(textBox1.Text));
                    break;
                case Operation.Module:
                    Resultado = Math.Abs(Convert.ToDouble(Valor));
                    break;
                case Operation.Radication:
                    Resultado = Math.Pow(Valor, 1.0 / Convert.ToDouble(textBox1.Text));
                    break;
            }
            textBox1.Text = Convert.ToString(Resultado);
        }

        private void Multplication_Click(object sender, EventArgs e)
        {
            selectedOperation = Operation.Multiplication;
            Valor = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            selectedOperation = Operation.Sum;
            Valor = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            selectedOperation = Operation.Subtraction;
            if (textBox1.Text == "")
            {
                Valor = 0;
            }
            else
            {
                Valor = Convert.ToDouble(textBox1.Text);
            }

            textBox1.Text = "";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            selectedOperation = Operation.Division;
            Valor = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Raiz_Click(object sender, EventArgs e)
        {
            selectedOperation = Operation.Radication;
            Valor = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3,14159265359";
        }

        private void Module_Click(object sender, EventArgs e)
        {
            selectedOperation = Operation.Module;
            Valor = Convert.ToDouble(textBox1.Text);
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            selectedOperation = Operation.Factorial;
            Valor = Convert.ToDouble(textBox1.Text);
        }

        private void Potencia_Click(object sender, EventArgs e)
        {
            selectedOperation = Operation.Potentiation;
            Valor = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void Logaritmo_Click(object sender, EventArgs e)
        {
            selectedOperation = Operation.Logarithm;
            Valor = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void Quatro_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void Sete_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void Oito_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void Cinco_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void Dois_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void Nove_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
    }
}
