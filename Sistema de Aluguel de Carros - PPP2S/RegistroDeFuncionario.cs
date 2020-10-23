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
    public partial class RegistroDeFuncionario : Form
    {
        List<Funcionario> ListFuncionarios;
        Funcionarios funcionarios;
        public RegistroDeFuncionario(Funcionarios funcionarios, List<Funcionario> ListFuncionarios)
        {
            InitializeComponent();
            this.ListFuncionarios = ListFuncionarios;
            this.funcionarios = funcionarios;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tBoxNome.Text != "" && tBoxEmail.Text != "" && tBoxSalario.Text != "" && tBoxSenha.Text != "" && tBoxSenha.Text != "" && tBoxLogin.Text != "" && tBoxCpf.MaskCompleted && tBoxRg.MaskCompleted && tBoxTelefone.MaskCompleted && tBoxAdmissao.MaskCompleted)
            {

                if (!ListFuncionarios.Exists(f => f.rg == tBoxRg.Text))
                {
                    Registrar(tBoxNome.Text, tBoxRg.Text, tBoxCpf.Text, tBoxEmail.Text, tBoxTelefone.Text, boxCargo.Text, boxSetor.Text, Convert.ToSingle(tBoxSalario.Text), tBoxAdmissao.Text,tBoxLogin.Text, tBoxSenha.Text, boxAcesso.Text);

                }
                else { MessageBox.Show("Funcionario ja existe"); }
            }
            else { MessageBox.Show("por favor,preencha todos os dados"); }
        }
        private void Registrar(string nome, string rg, string cpf, string email, string telefone, string cargo, string setor, float salario, string admissao, string login, string senha, string acesso)
        {
            Funcionario novoFuncionario = new Funcionario();

            novoFuncionario.nome = nome;
            novoFuncionario.rg = rg;
            novoFuncionario.cpf = cpf;
            novoFuncionario.email = email;
            novoFuncionario.telefone = telefone;
            novoFuncionario.cargo = cargo;
            novoFuncionario.setor = setor;
            novoFuncionario.salario = salario;
            novoFuncionario.dataAdmssao = admissao;
            novoFuncionario.login = login;
            novoFuncionario.senha = senha;
            novoFuncionario.nivelAcesso = acesso;

            ListFuncionarios.Add(novoFuncionario);
            funcionarios.AtualizarTabela();
            this.Close();
        }
    }
    
}
