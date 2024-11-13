using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalhoPOO_27209_Fase1;

namespace trabalhoPOO_27209_Fase1.Class
{
    public class Contrato
    {
        private static int proximoId = 1;
        public int IdContrato { get; private set; }
        public Imovel Imovel { get; set; }
        public Inquilino Inquilino { get; set; }
        public Proprietario Proprietario { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal ValorAluguel { get; set; }
        public bool Ativo { get; set; }

        public Contrato()
        {
            IdContrato = proximoId++;
        }

        public override string ToString()
        {
            return $"Imovel: {Imovel.IdImovel} - Proprietario: {Inquilino.Nome} - Inquilino: {Inquilino.Nome}";
        }
    }
}