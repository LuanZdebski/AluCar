using Sistema_de_Aluguel_de_Carros___PPP2S.Entidades;
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
    public partial class RetornoDeVeiculo : Form
    {
        Inicio TelaInicial;
        Aluguel aluguel;
        float franquia;
        
        public RetornoDeVeiculo(Inicio TelaInicial, Aluguel aluguel )
        {
            InitializeComponent();

            this.TelaInicial = TelaInicial;
            this.aluguel = aluguel;

            txtNomeDoCliente.Text = aluguel.clienteNome;
            txtModelo.Text = aluguel.veiculo;
            txtPlaca.Text = aluguel.veiculoPlaca;
            txtPlano.Text = aluguel.plano;
            txtDataRetirada.Text = aluguel.dataRetirada;
            txtDataDevolucao.Text = aluguel.dataDevolucao;
            franquia = ((TelaInicial.TelaControleFrota.ListVeiculos.Find(v => v.placa == aluguel.veiculoPlaca).valorDeCompra) / 100);
            txtValorSeguro.Text = "R$" + ((TelaInicial.TelaControleFrota.ListVeiculos.Find(v => v.placa == aluguel.veiculoPlaca).valorDeCompra) / 100);
            txtMultaTotal.Text = "R$0";
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            bool multaKm = checkMultaKm.Checked;
            bool multaAtraso = checkMultaAtraso.Checked;
            bool dano = checkDanos.Checked;
            bool multaSeguro = checkMultaSeguro.Checked;
            bool valido = true;
            bool valido2 = true;
            bool valido3= true;
            if (multaKm && nUpDownQntKm.Value == 0) { MessageBox.Show("Informe a quantidade de quilimetragem a ser cobrada, ou desative a cobrança"); valido = false; }
            else if (multaKm && nUpDownQntKm.Value > 0) { valido = true; }
            else if (!multaKm) { valido = true; }
            if (dano && descDano.Text == "") { MessageBox.Show("Descreva os danos do veículo, ou desative a cobrança"); valido2 = false; }
            else if (dano && descDano.Text != "") { valido2 = true; }
            else if (!dano) { valido2 = true; }
            if (multaAtraso && nUpDownDias.Value == 0) { MessageBox.Show("Informe a quantidade de diárias a ser cobrada, ou desative a cobrança"); valido3 = false; }
            else if (multaAtraso && nUpDownDias.Value > 0) { valido3 = true; }
            else if (!multaAtraso) { valido3 = true; }


            if (valido && valido2 && valido3)
            {
                MessageBox.Show
                    (
                    "Recibo"
                    );

                TelaInicial.TelaControleFrota.ListVeiculos.Find(v => v.placa == aluguel.veiculoPlaca).status = true;
                TelaInicial.TelaControleFrota.SalvarAoFechar();
                TelaInicial.TelaClientes.ListAlugueis.Remove(TelaInicial.TelaClientes.ListAlugueis.Find(a => a.veiculoPlaca == aluguel.veiculoPlaca));
                TelaInicial.TelaClientes.SalvarExternamenteEmBanco(TelaInicial.TelaClientes.ListAlugueis);
                TelaInicial.TelaClientes.AtualizarTabela();
                this.Close();
            }
        }
        private void CalcularValores()
        {
            float valor = 0;
            if (checkMultaKm.Checked) { valor = valor + ((TelaInicial.TelaControleFrota.ListVeiculos.Find(v => v.placa == aluguel.veiculoPlaca).valorDeCompra) / 2000)*Convert.ToInt32(nUpDownQntKm.Value); }
            if (checkMultaAtraso.Checked) { valor = valor + (20 * Convert.ToInt32(nUpDownDias.Value));  }
            if (checkMultaSeguro.Checked) { valor = valor + franquia; }
            txtMultaTotal.Text = "R$" + valor;

        }

        private void checkMultaKm_CheckedChanged(object sender, EventArgs e)
        {
            CalcularValores();
            nUpDownQntKm.Enabled = checkMultaKm.Checked;
        }

        private void checkMultaAtraso_CheckedChanged(object sender, EventArgs e)
        {
            CalcularValores();
            nUpDownDias.Enabled = checkMultaAtraso.Checked;
        }

        private void checkDanos_CheckedChanged(object sender, EventArgs e)
        {
            CalcularValores();
            descDano.Enabled = checkDanos.Checked;
        }

        private void checkMultaSeguro_CheckedChanged(object sender, EventArgs e)
        {
            CalcularValores();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nUpDownQntKm_ValueChanged(object sender, EventArgs e)
        {
            CalcularValores();
        }

        private void nUpDownDias_ValueChanged(object sender, EventArgs e)
        {
            CalcularValores();
        }
    }
}
