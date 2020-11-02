using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Aluguel_de_Carros___PPP2S.Entidades
{
    public class Aluguel
    {
        public string clienteNome { get; set; }
        public string clienteCpf { get; set; }
        public string clienteRg { get; set; }
        public string clienteEndereco { get; set; }
        public string clienteTelefone { get; set; }
        public string veiculo { get; set; }
        public string veiculoCor { get; set; }
        public string veiculoPlaca { get; set; }
        public string alugadoPor { get; set; }
        public string dataRetirada { get; set; }
        public string dataDevolucao { get; set; }
        public string plano { get; set; }
        public string formaPagamendo { get; set; }

    }
}
