using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversorMoedas
{
    public partial class Form1 : Form
    {
        float valorReal, valorDolar, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //saber o valor em R$
            valorReal = float.Parse(txtValorReal.Text);
            //saber o valor do dólar = R$5,27  $1 = R$5,27 REGRA DE TRÊS

            //converter de real para dolar
            resultado = valorReal / valorDolar;
            //mostrar resultado na label resultado
            lblResultado.Text = resultado.ToString();
        }
    }
}
