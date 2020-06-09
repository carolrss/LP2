using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
namespace atividade7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnativ1_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };
            Int32 Total = 0;
            Int32 N = Alunos.Length;
            foreach (string nome in Alunos)
            {
                Total += nome.Length;
                
            }
            MessageBox.Show("Alternativa a:" +Convert.ToString(Total));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList nome = new ArrayList(new string[]{ "Ana", "André", "Debora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" });
            nome.Remove("Otávio");
            string final = " ";
            foreach(string pessoa in nome)
            {
                final += pessoa + " ";
            }

            MessageBox.Show(final);


        }

        private void btnativ1_Click_1(object sender, EventArgs e)
        {
            int[] numeros = new int[20];
            int i = 0;
            string aux = " ";
            string valor = "";
            for ( i = 0; i < 20; i++ )
            {
                valor = Interaction.InputBox("Digite o Dado" + (i + 1), "Entrada de dados");

                if (int.TryParse(valor, out numeros[i]))
                {                
                    aux = numeros[i].ToString() + " " + aux;                                       
                }
                else
                {
                    MessageBox.Show("O dado digitado não é um númeto inteiro ");
                    i--;
                }
            }
             MessageBox.Show(aux);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int[] numeros = new int[20];
            int i = 0;
            string aux = " ";
            string valor = "";
            for (i = 0; i < 20; i++)
            {
                valor = Interaction.InputBox("Digite o Dado" + (i + 1), "Entrada de dados");

                if (int.TryParse(valor, out numeros[i]))
                {
                    numeros[i] = Convert.ToInt32(valor);
                }
                else
                {
                    MessageBox.Show("O dado digitado não é um númeto inteiro ");
                    i--;
                }
            }
            Array.Reverse(numeros);
            for (i = 0; i < 20; i++)
            {
                aux += Convert.ToString(numeros[i]) + " "; 
            }
            MessageBox.Show(aux);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] quantidade = new double[10];
            double[] preco = new double[10];
            int i = 0;
            double faturamento = 0;
            string qtde, valor = " ";

            for ( i = 0; i< 10; i++)
            {
                qtde = Interaction.InputBox("Digite a quantidade do produto: " + (i + 1), "Quantidade");
                if(double.TryParse(qtde, out quantidade[i]))
                {
                    do
                    {
                     valor = Interaction.InputBox("Digite o valor do produto: " + (i + 1), "Preço");
                    } 
                    while (!double.TryParse(valor, out preco[i]));
                }
                else
                {
                    MessageBox.Show("Quantidade Inválida");
                    i--;
                }

            }
            for (i = 0; i<10; i++)
            {
                faturamento += quantidade[i] * preco[i];
            }
            MessageBox.Show("O faturamento é: "+ Convert.ToString(faturamento));

        }
    }
}
