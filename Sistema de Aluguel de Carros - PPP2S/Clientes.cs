using Newtonsoft.Json;
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
    public partial class Clientes : Form
    {
        public List<Aluguel> ListAlugueis = new List<Aluguel>();

        String banco = @"..\..\BancoDeDados\bancoAlugueis.json";
        Inicio TelaInicial;
        
        public Clientes(Inicio TelaInicial)
        {
            InitializeComponent();
            btnAbaClientes.BackColor = Color.DarkOrange;

            try
            { ListAlugueis = CarregarBanco(banco); }
            catch
            { }
            AtualizarTabela();

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
        //banco de dados
        public void SalvarExternamenteEmBanco(List<Aluguel> lista)
        {
            SalvarAlugueisBanco(banco, lista);
        }
        static private void SalvarAlugueisBanco(String arquivo, List<Aluguel> lista)
        {
            StreamWriter file = new StreamWriter(arquivo);
            lista.ForEach(v =>
            {
                string output = JsonConvert.SerializeObject(v);
                file.WriteLine(output);

            });


            file.Close();
        }

        static private List<Aluguel> CarregarBanco(String banco)
        {
            string line;
            List<Aluguel> ListAlugueis = new List<Aluguel>();

            StreamReader file = new StreamReader(banco);

            while ((line = file.ReadLine()) != null)
            {
                Aluguel aluguel = JsonConvert.DeserializeObject<Aluguel>(line);
                ListAlugueis.Add(aluguel);
            }
            file.Close();
            return ListAlugueis;
        }
        public void AtualizarTabela()
        {

            TabelaAlugueis.Rows.Clear();
            for (int i = 0; i < ListAlugueis.Count; i++)
            {

                string[] linha = new string[6];
                linha[0] = ListAlugueis[i].veiculo;
                linha[1] = ListAlugueis[i].veiculoPlaca;
                linha[2] = ListAlugueis[i].dataRetirada;
                linha[3] = ListAlugueis[i].dataDevolucao;
                linha[4] = ListAlugueis[i].plano;

                TabelaAlugueis.Rows.Add(linha);


            }


        }

        private void btnCancelarLocacao_Click(object sender, EventArgs e)
        {
            if (TabelaAlugueis.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("A locação sera cancelada e o veiculo ficará disponível na frota,tem certeza?", "Cancelar Locação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    TelaInicial.TelaControleFrota.ListVeiculos.Find(v => v.placa == PlacaSelect()).status = true;
                    TelaInicial.TelaControleFrota.SalvarAoFechar();
                    ListAlugueis.Remove(ListAlugueis.Find(a => a.veiculoPlaca == PlacaSelect()));
                    SalvarAlugueisBanco(banco, ListAlugueis);
                    AtualizarTabela();

                }
            }
            
        
        }
        private string PlacaSelect()
        {

            string placa = "";
            foreach (DataGridViewRow row in TabelaAlugueis.SelectedRows)
            {

                placa = row.Cells[1].Value.ToString();


            }
            return placa;

        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            string placa = PlacaSelect();
            if (ListAlugueis.Exists(v => v.veiculoPlaca == placa))
            {
                Aluguel aluguel = new Aluguel();
                aluguel = ListAlugueis.Find(v => v.veiculoPlaca == placa);

                MessageBox.Show
                    ("Veículo: " + aluguel.veiculo + Environment.NewLine +
                     "cliente: " + aluguel.clienteNome + Environment.NewLine +
                     "CPF: " + aluguel.clienteCpf + Environment.NewLine +
                     "RG: " + aluguel.clienteRg + Environment.NewLine +
                     "telefone: " + aluguel.clienteTelefone + Environment.NewLine +
                     "endereço: " + aluguel.clienteEndereco + Environment.NewLine + 
                     "locação feita por: " + aluguel.alugadoPor + Environment.NewLine +
                     "data de retirada: " + aluguel.dataRetirada + Environment.NewLine +
                     "devolução prevista para: " + aluguel.dataDevolucao + Environment.NewLine +
                     "plano de aluguel: " + aluguel.plano + Environment.NewLine 
                    );
            }
            else { MessageBox.Show("Selecione uma linha para ver mais detalhes"); }
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            RetornoDeVeiculo retornoDeVeiculo = new RetornoDeVeiculo(TelaInicial, ListAlugueis.Find(a => a.veiculoPlaca == PlacaSelect()));
            retornoDeVeiculo.Show();
        }
    }
}
