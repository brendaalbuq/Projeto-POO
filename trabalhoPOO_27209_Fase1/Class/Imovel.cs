using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoPOO_27209_Fase1.Class
{
    public class Imovel
    {
        private static int proximoId = 1;
        public int IdImovel { get; private set; }
        public string TipoImovel { get; set; }
        public string Endereco { get; set; }
        public decimal ValorAluguel { get; set; }
        public decimal Despesas { get; set; }

        public Imovel()
        {
            IdImovel = proximoId++;
        }
        public override string ToString()
        {
            return $"Imóvel {IdImovel}: {TipoImovel} - {Endereco}";
        }

        public string DescricaoDisplay => $"ID {IdImovel} - {Endereco}";
    }

}