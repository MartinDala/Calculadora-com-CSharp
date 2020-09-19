using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDiferente
{
    public partial class Form1 : Form
    {
        double valor;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEntrar.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtEntrar.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtEntrar.Text += "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtEntrar.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtEntrar.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtEntrar.Text += "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtEntrar.Text += "7";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtEntrar.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtEntrar.Text += "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtEntrar.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(txtEntrar.Text);
             txtEntrar.Text = "+";
            txtEntrar.Text = "";
            operador = "+";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(txtEntrar.Text);
            label1.Text = txtEntrar.Text + "-";
            txtEntrar.Text = "";
            operador = "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(txtEntrar.Text);
            label1.Text = txtEntrar.Text + "/";
            txtEntrar.Text = "";
            operador = "/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(txtEntrar.Text);
            label1.Text = txtEntrar.Text + "x";
            txtEntrar.Text = "";
            operador = "x";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(txtEntrar.Text);
            label1.Text = txtEntrar.Text + "<";
            txtEntrar.Text = "";
            operador = "<";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(txtEntrar.Text);
            label1.Text = txtEntrar.Text + ">";
            txtEntrar.Text = "";
            operador = ">";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(txtEntrar.Text);
            label1.Text = txtEntrar.Text + "<=";
            txtEntrar.Text = "";
            operador = "<=";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(txtEntrar.Text);
            label1.Text = txtEntrar.Text + "<=";
            txtEntrar.Text = "";
            operador = "<=";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(txtEntrar.Text);
            label1.Text = txtEntrar.Text + "%";
            txtEntrar.Text = "";
            operador = "%";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(txtEntrar.Text);
            label1.Text = txtEntrar.Text + "==";
            txtEntrar.Text = "";
            operador = "==";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operador)
            {


                case "+": valor = valor + Convert.ToDouble(txtEntrar.Text);
                    label1.Text = label1.Text + txtEntrar.Text + "+";
                    txtEntrar.Text = Convert.ToString(valor);
                    break;
         
               case "-": valor = valor - Convert.ToDouble(txtEntrar.Text);
            label1.Text = label1.Text + txtEntrar.Text + "-";
            txtEntrar.Text = Convert.ToString(valor);
            break;

                case "/":
                    valor = valor / Convert.ToDouble(txtEntrar.Text);
                    label1.Text = label1.Text + txtEntrar.Text + "/";
                    txtEntrar.Text = Convert.ToString(valor);
                    break;


                case "x":
                    valor = valor * Convert.ToDouble(txtEntrar.Text);
                    label1.Text = label1.Text + txtEntrar.Text + "x";
                    txtEntrar.Text = Convert.ToString(valor);
                    break;
                case "%":
                    valor = valor % Convert.ToDouble(txtEntrar.Text);
                    label1.Text = label1.Text + txtEntrar.Text + "%";
                    txtEntrar.Text = Convert.ToString(valor);
                    break;


                case "==":
                    if (valor == Convert.ToDouble(txtEntrar.Text))
                    {

                        MessageBox.Show("São valores iguais");

                    }
                    else
                    {
                        MessageBox.Show("São valores diferentes");
                    }
                    break;

                case "<":
                    if(valor < Convert.ToDouble(txtEntrar.Text))
                    {
                        MessageBox.Show(valor + "É o Menor valor");
                    }
                    else
                    {
                        MessageBox.Show(Convert.ToDouble(txtEntrar.Text) + " É o menor valor");
                    }break;


                case ">":
                    if (valor > Convert.ToDouble(txtEntrar.Text))
                    {
                        MessageBox.Show(valor + "É o Maior valor");
                    }
                    else
                    {
                        MessageBox.Show(Convert.ToDouble(txtEntrar.Text) + " É o Maior valor");
                    }
                    break;


                case "<=":
                    if (valor < Convert.ToDouble(txtEntrar.Text))
                    {
                        MessageBox.Show(valor + "É Menor ou igual ao valor");
                    }
                    else
                    {
                        MessageBox.Show(Convert.ToDouble(txtEntrar.Text) + " É  Menor ou igual ao valor");
                    }
                    break;

                case ">=":
                    if (valor < Convert.ToDouble(txtEntrar.Text))
                    {
                        MessageBox.Show(valor + "É Maior ou igual ao valor");
                    }
                    else
                    {
                        MessageBox.Show(Convert.ToDouble(txtEntrar.Text) + " É  Maior ou igual ao valor");
                    }
                    break;


            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtEntrar.Clear();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
