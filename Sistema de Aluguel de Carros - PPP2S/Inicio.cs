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
    public partial class Inicio : Form
    {
        bool estaLogado = false;
        public string contaLogada;

        public ControleFrota TelaControleFrota;
        public Funcionarios TelaFuncionarios;
        public Clientes TelaClientes;
        public Financeiro TelaFinanceiro;
        public TI TelaTI;
        public Login login;

        public Inicio()
        {
            InitializeComponent();           
            btnAbaInicio.BackColor = Color.DarkOrange;

        }
        private void Inicio_Shown(object sender, EventArgs e)
        {
            TrocarTelas(this, login);
        }
        private void Inicio_Load(object sender, EventArgs e)
        {

            TelaControleFrota = new ControleFrota(this);
            TelaFuncionarios = new Funcionarios(this);
            TelaClientes = new Clientes(this);
            TelaFinanceiro = new Financeiro(this);
            TelaTI = new TI(this);

        }
        //Botoes comuns
        private void btnAbaControleFrota_Click(object sender, EventArgs e)
        {
            TrocarTelas(this, TelaControleFrota);
        }

        private void btnControleFuncionarios_Click(object sender, EventArgs e)
        {
            TrocarTelas(this, TelaFuncionarios);
        }

        private void btnAbaClientes_Click(object sender, EventArgs e)
        {
            TrocarTelas(this, TelaClientes);
        }

        private void btnAbaFinanceiro_Click(object sender, EventArgs e)
        {
            TrocarTelas(this, TelaFinanceiro);
        }

        private void btnAbaTI_Click(object sender, EventArgs e)
        {
            TrocarTelas(this, TelaTI);
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            TelaControleFrota.SalvarAoFechar();
            FecharAplicativo();
        }


        //metodo de troca de telas
        public void TrocarTelas(Form pedido, Form nova)
        {
            if (pedido == this) { pedido.Hide(); }
            else { pedido.Close(); }
            if (nova == login) { login = new Login(this); nova = login; nova.Show(); }
            else if (nova == TelaControleFrota) { TelaControleFrota = new ControleFrota(this); nova = TelaControleFrota; nova.Show(); }
            else if (nova == TelaFuncionarios) { TelaFuncionarios = new Funcionarios(this); nova = TelaFuncionarios; nova.Show(); }
            else if (nova == TelaClientes) { TelaClientes = new Clientes(this); nova = TelaClientes; nova.Show(); }
            else if (nova == TelaFinanceiro) { TelaFinanceiro = new Financeiro(this); nova = TelaFinanceiro; nova.Show(); }
            else if (nova == TelaTI) { TelaTI = new TI(this); nova = TelaTI; nova.Show(); }
            else { nova.Show(); }
            
            
        }
        //metodo fechar o aplicativo
        public void FecharAplicativo()
        {
            this.Close();
        }


        public void Logar()
        {
            txtLogadoComo.Text = "Logado como: " + contaLogada;
            estaLogado = true;
        }

    }
}
