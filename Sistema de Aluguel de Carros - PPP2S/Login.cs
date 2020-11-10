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
    public partial class Login : Form
    {
        String banco = @"..\..\BancoDeDados\bancoFuncionarios.json";
        List<Funcionario> ListFuncionarios = new List<Funcionario>();
        Inicio TelaInicial;
        public Login(Inicio TelaInicial)
        {
            InitializeComponent();
            ListFuncionarios = CarregarBanco(banco);
            this.TelaInicial = TelaInicial;
        }

 

        private void btnFechar_Click(object sender, EventArgs e)
        {
            TelaInicial.FecharAplicativo();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginIn();
            
        }
        private void LoginIn()
        {
            if (tBoxUsuario.Text != "" && tBoxSenha.Text != "")
            {
                if (ListFuncionarios.Exists(f => f.login == tBoxUsuario.Text))
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario = ListFuncionarios.Find(f => f.login == tBoxUsuario.Text);
                    if (funcionario.senha == tBoxSenha.Text)
                    {

                        TelaInicial.contaLogada = funcionario.nome;
                        TelaInicial.estaLogado = true;
                        TelaInicial.Logar();
                        TelaInicial.TrocarTelas(this, TelaInicial);


                    }
                    else { MessageBox.Show("Senha ou usuário invalido"); }
                }
                else { MessageBox.Show("Senha ou usuário invalido"); }
            }
            else { MessageBox.Show("Insira suas credenciais"); }
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
    }
}
