using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[,] VendasMeses = new double[6, 4];
            double[] TotalCadaMes = new double[6];
            double TotalGeral = 0;
            int m, s = 0;
            string valores = "";

            for ( m = 0; m < 6; m++ )
            {
                for ( s = 0; s < 4; s++ )
                {
                    valores = Interaction.InputBox("Mês: " + (m + 1) + "\n" + "Digite o valor de vendas da semana " + (s + 1), "Valor das Vendas na semana");
                    if (double.TryParse(valores,out VendasMeses[m,s]))
                    {
                        
                        lstbResultado.Items.Add("Total do mês: " + (m + 1) + " Semana: " + (s + 1) + " R$" +VendasMeses[m, s].ToString("N2")+"\n");
                        TotalCadaMes[m] += VendasMeses[m, s];
                       

                    }
                    else
                    {
                        MessageBox.Show(" Erro: Valor Inválido");
                        s--;
                    }
                }
                
                lstbResultado.Items.Add(">> Total Mês:R$" + TotalCadaMes[m].ToString("N2")+"\n");
                lstbResultado.Items.Add("--------------"+"\n");
                TotalGeral += TotalCadaMes[m];
               


            }
            
            lstbResultado.Items.Add(">> Total Geral:R$" + TotalGeral.ToString("N2"));
             

        }
    }
}
