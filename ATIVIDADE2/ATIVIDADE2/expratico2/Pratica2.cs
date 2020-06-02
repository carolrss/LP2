using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expratico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double altura; 
            double PesoAtual;
             double pesoideal;

            if ( double.TryParse(msktxtbaltura.Text, out altura) && double.TryParse(msktxtbpesoatual.Text, out PesoAtual) )
            {
                if (rdbtnfeminino.Checked)
                {
                    pesoideal = (62.1 * altura) - 44.7;
                }
                else
                {
                    pesoideal = (72.7 * altura) - 58;
                }
                pesoideal = Math.Round(pesoideal, 2);
                
                if (PesoAtual < pesoideal )
                {
                    msktxtpesoideal.Text = Convert.ToString(pesoideal);
                    MessageBox.Show(Convert.ToString(pesoideal)+"\n"+"Coma bastante massas e doces");
                }
                if (pesoideal == PesoAtual)
                {
                    msktxtpesoideal.Text = Convert.ToString(pesoideal);
                    MessageBox.Show(Convert.ToString(pesoideal) + "\n" + "Você está com o peso ideal");
                }
                else
                {
                    msktxtpesoideal.Text = Convert.ToString(pesoideal);
                    MessageBox.Show(Convert.ToString(pesoideal) + "\n" + "Regime obrigatório já");
                }
            } 
            else
            {
                MessageBox.Show("Dados invalidos");
            }
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
