using Sistema_de_Aluguel_de_Carros___PPP2S.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Aluguel_de_Carros___PPP2S
{
    public partial class LocarVeiculo : Form
    {
        ControleFrota frota;
        Inicio TelaInicial;
        List<Aluguel> ListAlugueis;
        Clientes clientes;
        float ValorVeiculo;
        
        public LocarVeiculo(Inicio TelaInicial,Veiculo veiculo, List<Aluguel> ListAlugueis)
        {
            InitializeComponent();
            this.ListAlugueis = ListAlugueis;
            this.TelaInicial = TelaInicial;
            this.frota = TelaInicial.TelaControleFrota;
            this.clientes = TelaInicial.TelaClientes;
            this.ValorVeiculo = veiculo.valorDeCompra;
            

            txtModelo.Text = veiculo.fabricante + " " + veiculo.modelo + " " + veiculo.ano;
            txtCor.Text = veiculo.cor;
            txtPlaca.Text = veiculo.placa;
            string[] adcionais = new string[8] { "Ar condicionado", "Direção hidraulica", "Trava elétrica", "Teto solar", "Vidro elétrico", "Bancos de couro", "Camera de ré", "Cambio automatico" };
            StringWriter adcionaisLinha = new StringWriter();
           
            
            if (veiculo.arCondicionado) { adcionaisLinha.Write(adcionais[0] + Environment.NewLine); }
            if (veiculo.direcaoHidraulica) { adcionaisLinha.Write(adcionais[1] + Environment.NewLine); }
            if (veiculo.travaEletrica) { adcionaisLinha.Write(adcionais[2] + Environment.NewLine); }
            if (veiculo.tetoSolar) { adcionaisLinha.Write(adcionais[3] + Environment.NewLine); }
            if (veiculo.vidroEletrico) { adcionaisLinha.Write(adcionais[4] + Environment.NewLine); }
            if (veiculo.bancosCouro) { adcionaisLinha.Write(adcionais[5] + Environment.NewLine); }
            if (veiculo.cameraRe) { adcionaisLinha.Write(adcionais[6] + Environment.NewLine); }
            if (veiculo.cambioAutomatico) { adcionaisLinha.Write(adcionais[7] + Environment.NewLine); }
            AtualizarValores();
            txtAdicionais.Text = adcionaisLinha.ToString();
        }

        private void btnLocar_Click(object sender, EventArgs e)
        {
            if (tBoxNome.Text != "" && tBoxCpf.Text != "" && tBoxRg.Text != "" && tBoxEndereco.Text != "" && tBoxRetirada.MaskCompleted && tBoxDevolucao.MaskCompleted && tBoxTelefone.MaskCompleted && cBoxPlano.Text != "" && cBoxPagamento.Text != "" )
            {
                Aluguel novoAluguel = new Aluguel();

                novoAluguel.clienteNome = tBoxNome.Text;
                novoAluguel.clienteRg = tBoxRg.Text;
                novoAluguel.clienteCpf = tBoxCpf.Text;
                novoAluguel.clienteEndereco = tBoxEndereco.Text;
                novoAluguel.clienteTelefone = tBoxTelefone.Text;
                novoAluguel.veiculo = txtModelo.Text;
                novoAluguel.veiculoCor = txtCor.Text;
                novoAluguel.veiculoPlaca = txtPlaca.Text;
                novoAluguel.plano = cBoxPlano.Text;
                novoAluguel.formaPagamendo = cBoxPagamento.Text;
                novoAluguel.dataRetirada = tBoxRetirada.Text;
                novoAluguel.dataDevolucao = tBoxDevolucao.Text;
                novoAluguel.alugadoPor = TelaInicial.contaLogada;

                ListAlugueis.Add(novoAluguel);
                clientes.SalvarExternamenteEmBanco(ListAlugueis);
                frota.ListVeiculos.Find(V => V.placa == novoAluguel.veiculoPlaca).status = false;
                frota.SalvarAoFechar();
                frota.AtualizarTabela();
                this.Close();

            }
            else { MessageBox.Show("Preecha todos os campos"); }
        }
        private void AtualizarValores()
        {
            
            float desconto = Convert.ToSingle(cBoxDesconto.Text.Replace("%", ""));
            float juros = Convert.ToSingle(cBoxJuros.Text.Replace("%", ""));
            float valor = 0;
           
            if (cBoxPlano.Text == "Km Controlada")
            {
                
                txtValorDiaria.Text = ((ValorVeiculo / 1300) - ((ValorVeiculo / 1300) / 100 * desconto)).ToString("C2");
                txtValorTotal.Text = "";
                valor = (((ValorVeiculo / 1300) - ((ValorVeiculo / 1300) / 100 * desconto)));
            }
            if (cBoxPlano.Text == "Km Livre")
            {
                
                txtValorDiaria.Text = ((ValorVeiculo / 1000) - ((ValorVeiculo / 1000) / 100 * desconto)).ToString("C2");
                txtValorTotal.Text = "";
                valor =  (((ValorVeiculo / 1000) - ((ValorVeiculo / 1000) / 100 * desconto)));
            }
           
            if (tBoxRetirada.MaskCompleted && tBoxDevolucao.MaskCompleted) 
            {
              
                txtValorTotal.Text = ((valor * CalcularDiarias()) + ((valor * CalcularDiarias()) / 100) * juros).ToString("C2");
            }
        }
        private int CalcularDiarias()
        {
            DateTime retirada = new DateTime(2020, 1, 1);
            DateTime devolucao = new DateTime(2020, 1, 1);
            try
            {
                retirada = Convert.ToDateTime(tBoxRetirada.Text);
                devolucao = Convert.ToDateTime(tBoxDevolucao.Text);
            }
            catch { return 1; }

            int dif = Convert.ToInt32((devolucao - retirada).TotalDays);

            return dif;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBoxDesconto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void cBoxJuros_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void cBoxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void cBoxPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }
     
        private void tBoxDevolucao_TextChanged(object sender, EventArgs e)
        {
            if (tBoxDevolucao.MaskCompleted) 
            {
             
                if (Convert.ToDateTime(tBoxDevolucao.Text) <= Convert.ToDateTime(tBoxRetirada.Text))
                {
                    MessageBox.Show("Data inválida, devolução não pode ser antes ou no mesmo dia de retirada. Alterada para q dia depois da retirada");
                    DateTime retirada = Convert.ToDateTime(tBoxRetirada.Text);
                    retirada = retirada.AddDays(1);
                    tBoxDevolucao.Text = retirada.ToString();

                }
                txtNumDiarias.Text = CalcularDiarias() + " Diárias";
                AtualizarValores();
            }
        }

        private void tBoxRetirada_TextChanged(object sender, EventArgs e)
        {
            if (tBoxRetirada.MaskCompleted)
            {
                if (Convert.ToDateTime(tBoxRetirada.Text) < DateTime.Today)
                {
                    MessageBox.Show("Data inválida. Alterada para o dia de hoje");
                    tBoxRetirada.Text = DateTime.Now.ToString();

                }
                txtNumDiarias.Text = CalcularDiarias() + " Diárias";
                AtualizarValores();
            }
        }
    }
}
