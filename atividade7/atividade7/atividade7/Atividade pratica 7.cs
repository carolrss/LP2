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

        private void ativ6_Click(object sender, EventArgs e)
        {
            double[,] alunosnotas = new double[20, 3];
            string notas= "";
            int l, c = 0;
            double[] media = new double[20];
            string mediafinal = "";
                        
            for (l = 0; l<20; l++ )
            {
                for(c=0; c<3; c++)
                {
                    notas = Interaction.InputBox("Digite a nota "+(c+1)+ " do aluno: " + (l + 1), "Notas");
                    if (double.TryParse(notas, out alunosnotas[l,c] ))
                    {
                        media[l] += alunosnotas[l,c] / 3;
                        media[l] = Math.Round(media[l], 2);
                    }
                    else
                    {
                        MessageBox.Show("Nota inválida");
                        c--;
                    }
                }
            }
            
                for(l = 0; l < 20; l++)
            {
                  
              mediafinal += "Aluno " +(l+1) + " media: "+ Convert.ToString(media[l]) + "\n";
            }

            MessageBox.Show(mediafinal);
        }

        private void ativ7_Click(object sender, EventArgs e)
        {
            ArrayList nome = new ArrayList(new string[6]);
            int l = 0;


            for(l=0; l<6; l++)
            {
                nome[l] = Interaction.InputBox("Digite o nome: " + (l + 1), "Nomes");

            }
            foreach(string caracter in nome)
            {
                if (caracter == "")
                    nome.RemoveAt(caracter);
            }

        }
    }
}
