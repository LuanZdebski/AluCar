using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Aluguel_de_Carros___PPP2S
{
    public partial class Clientes : Form
    {
        Inicio TelaInicial;
        public Clientes(Inicio TelaInicial)
        {
            InitializeComponent();
            btnAbaClientes.BackColor = Color.DarkOrange;
            this.TelaInicial = TelaInicial;

            txtLogadoComo.Text = "Logado como: " + TelaInicial.contaLogada;
        }
        //botoes comuns
        private void btnAbaInicio_Click(object sender, EventArgs e)
        {
            TelaInicial.TrocarTelas(this, TelaInicial);
        }

        private void btnAbaControleFrota_Click(object sender, EventArgs e)
        {
            TelaInicial.TrocarTelas(this, TelaInicial.TelaControleFrota);
        }

        private void btnControleFuncionarios_Click(object sender, EventArgs e)
        {
            TelaInicial.TrocarTelas(this, TelaInicial.TelaFuncionarios);
        }

        private void btnAbaClientes_Click(object sender, EventArgs e)
        {
            TelaInicial.TrocarTelas(this, TelaInicial.TelaClientes);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            TelaInicial.TrocarTelas(this, TelaInicial.TelaFinanceiro);
        }

        private void btnAbaTI_Click(object sender, EventArgs e)
        {
            TelaInicial.TrocarTelas(this, TelaInicial.TelaTI);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            TelaInicial.FecharAplicativo();
        }
    }
}
