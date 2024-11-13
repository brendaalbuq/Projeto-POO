using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoPOO_27209_Fase1.Class
{
    public class Proprietario
    {
        private static int proximoId = 1;
        public int IdProprietario { get; private set; }
        public string Nome { get; set; }
        public int NIF { get; set; }
        public int Contato { get; set; }
        public int Imoveis { get; set; }

        public Proprietario()
        {
            IdProprietario = proximoId++;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} - NIF: {NIF}";
        }

    }
}