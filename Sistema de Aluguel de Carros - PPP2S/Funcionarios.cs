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
    public partial class Funcionarios : Form
    {
        Inicio TelaInicial;


        String banco = @"..\..\BancoDeDados\bancoFuncionarios.json";

        List<Funcionario> ListFuncionarios = new List<Funcionario>();
        public Funcionarios(Inicio TelaInicial)
        {
            InitializeComponent();
            btnControleFuncionarios.BackColor = Color.DarkOrange;

            try
            { ListFuncionarios = CarregarBanco(banco); }
            catch
            { }
            AtualizarTabela();

            this.TelaInicial = TelaInicial;

            txtLogadoComo.Text = "Logado como: " + TelaInicial.contaLogada;
        }

        static private List<Funcionario> CarregarBanco(String banco)
        {
            string line;
            List<Funcionario> ListFuncionarios = new List<Funcionario>();

            StreamReader file = new StreamReader(banco);

            while ((line = file.ReadLine()) != null)
            {
                Funcionario funcionario = JsonConvert.DeserializeObject<Funcionario>(line);
                ListFuncionarios.Add(funcionario);
            }
            file.Close();
            return ListFuncionarios;
        }
        static private void SalvarListaVeiculos(String arquivo, List<Funcionario> lista)
        {
            StreamWriter file = new StreamWriter(arquivo);
            lista.ForEach(v =>
            {
                string output = JsonConvert.SerializeObject(v);
                file.WriteLine(output);

            });


            file.Close();
        }
        //Botoes comuns
        private void btnAbaInicio_Click(object sender, EventArgs e)
        {
            SalvarListaVeiculos(banco, ListFuncionarios);
            TelaInicial.TrocarTelas(this, TelaInicial);
        }

        private void btnAbaControleFrota_Click(object sender, EventArgs e)
        {
            SalvarListaVeiculos(banco, ListFuncionarios);
            TelaInicial.TrocarTelas(this, TelaInicial.TelaControleFrota);
        }

        private void btnAbaClientes_Click(object sender, EventArgs e)
        {
            SalvarListaVeiculos(banco, ListFuncionarios);
            TelaInicial.TrocarTelas(this, TelaInicial.TelaClientes);
        }

        private void btnAbaFinanceiro_Click(object sender, EventArgs e)
        {
            SalvarListaVeiculos(banco, ListFuncionarios);
            TelaInicial.TrocarTelas(this, TelaInicial.TelaFinanceiro);
        }

        private void btnAbaTI_Click(object sender, EventArgs e)
        {
            SalvarListaVeiculos(banco, ListFuncionarios);
            TelaInicial.TrocarTelas(this, TelaInicial.TelaTI);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            SalvarListaVeiculos(banco, ListFuncionarios);
            TelaInicial.FecharAplicativo();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroDeFuncionario registro = new RegistroDeFuncionario(this, ListFuncionarios);
            registro.Show();
        }
        public void AtualizarTabela()
        {

            TabelaFuncionarios.Rows.Clear();
            for (int i = 0; i < ListFuncionarios.Count; i++)
            {

                string[] linha = new string[4];
                linha[0] = ListFuncionarios[i].nome;
                linha[1] = ListFuncionarios[i].cargo;
                linha[2] = ListFuncionarios[i].setor;
               

                TabelaFuncionarios.Rows.Add(linha);


            }

        }

        private void btnRemoverFuncionarios_Click(object sender, EventArgs e)
        {
            string funcionario = FuncionarioSelect();

            if (ListFuncionarios.Exists(v => v.nome == funcionario))
            {
                DialogResult dialogResult = MessageBox.Show("O funcionario sera removido, tem certeza?", "Remover Funcionario", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ListFuncionarios.Remove(ListFuncionarios.Find(v => v.nome == FuncionarioSelect()));
                    MessageBox.Show("O funcionario: " + funcionario + " foi removido");
                    AtualizarTabela();
                    SalvarListaVeiculos(banco, ListFuncionarios);
                }
            }
            else { MessageBox.Show("Selecione a linha do funcionario que deseja excluir"); }
        }
        private string FuncionarioSelect()
        {

            string funcionario = "";
            foreach (DataGridViewRow row in TabelaFuncionarios.SelectedRows)
            {

                funcionario = row.Cells[0].Value.ToString();


            }
            return funcionario;

        }


    }
}
