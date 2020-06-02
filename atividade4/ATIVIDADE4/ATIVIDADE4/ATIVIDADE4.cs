using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salariobruto = 0;
            int numfilhos = 0;
            double salariofamilia = 0;
            double salarioliquido = 0;
            double INSS = 0;
            double IRPF = 0;
            
            if (double.TryParse(msktxtbsalariobruto.Text, out salariobruto)&&
                int.TryParse(msktxtbfilhos.Text, out numfilhos))
            {
                if ( salariobruto <= 800.47)
                {
                    msktxtbaliquotaINSS.Text = "7.65%";
                    INSS = salariobruto * 0.0765;
                }
                else if (salariobruto <= 1050)
                {
                    msktxtbaliquotaINSS.Text = "8.65%";
                    INSS = salariobruto * 0.0865;

                }
                else if (salariobruto <= 1400.77)
                {
                    msktxtbaliquotaINSS.Text = "9.00%";
                    INSS = salariobruto * 0.09;
                }
                else if (salariobruto <= 2801.56)
                {
                    msktxtbaliquotaINSS.Text = "11.00%";
                    INSS = salariobruto * 0.11;
                }
                else
                {
                    msktxtbaliquotaINSS.Text = "teto";
                    INSS = 308.17;
                }
                if (salariobruto <= 1257.12)
                {
                    msktxtbaliquotaIRPF.Text = "0";
                    IRPF = 0;
                }  
                else if ( salariobruto <= 2512.08)
                {
                    msktxtbaliquotaIRPF.Text = "15%";
                    IRPF = salariobruto * 0.15;

                }
                else
                {
                    msktxtbaliquotaIRPF.Text = "27.5%";
                    IRPF = salariobruto * 0.275;
                }
                if (numfilhos > 0)
                {
                    if (salariobruto <= 435.52)
                    {
                        salariofamilia = 22.33 * numfilhos;
                    }
                    else if (salariobruto <= 654.61)
                    {
                        salariofamilia = 15.74 * numfilhos;
                    }
                    else
                    {
                        salariofamilia = 0;
                    }
                    

                }
                salarioliquido = salariobruto - INSS - IRPF + salariofamilia;
                msktxtbdescontoINSS.Text = INSS.ToString("N2");
                msktxtbdescontoIRPF.Text = IRPF.ToString("N2");
                msktxtbsalariofamilia.Text = salariofamilia.ToString("N2");
                msktxtbsalarioliquido.Text = salarioliquido.ToString("N2");

                lbdDados.Text = "Os descontos do salário" + (rdbtnMulher.Checked ? "da Sra " : "do Sr") + msktxtbnome.Text + "\n" +
                    "que é " + (ckbCasado.Checked ? "Casado(a)" : "Solteiro(a)") + "\n" +
                    "e que tem " + Convert.ToString(numfilhos) + " filhos são: ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
