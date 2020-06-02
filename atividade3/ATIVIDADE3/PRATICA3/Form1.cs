using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRATICA3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;
            double resultadoA, resultadoB, resultadoC;
            
            if (double.TryParse(txtbladoA.Text, out ladoA) &&
                double.TryParse(txtbladoB.Text, out ladoB) &&
                double.TryParse(txtbladoC.Text, out ladoC))
            {
                if ( ladoB > ladoC)
                {
                    resultadoA = ladoB - ladoC;
                }
                else
                {
                    resultadoA = ladoC - ladoB;
                }
                if (ladoA > ladoC)
                {
                    resultadoB = ladoA - ladoC;
                }
                else
                {
                    resultadoB = ladoC - ladoA;
                }
                if (ladoA > ladoB)
                {
                    resultadoC = ladoA - ladoB;
                }
                else
                {
                    resultadoC = ladoB - ladoA;
                }
                if ( resultadoA < ladoA && ladoA < (ladoB+ladoC)&&
                     resultadoB < ladoB && ladoB < (ladoA + ladoC) &&
                      resultadoC < ladoC && ladoC < ladoA + ladoB)
                {
                    MessageBox.Show("Os lados A,B e C formam um triângulo");

                }
                else
                {
                    MessageBox.Show("Os lados A,B e C não formam um triângulo");
                }
            }
            else
            {
                MessageBox.Show("Dados invalidos");
            }
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
