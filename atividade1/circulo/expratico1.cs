using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double raio;
            double altura;
            double volume;
             raio =Convert.ToDouble(this.txtbraio.Text);
             altura= Convert.ToDouble(this.txtbaltura.Text);
            volume = 3.14 * (raio * raio * altura);
            txtbvolume.Text = volume.ToString();
            

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
