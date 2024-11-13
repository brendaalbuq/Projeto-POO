using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoPOO_27209_Fase1.Class
{
    public class Inquilino
    {
        private static int proximoID = 1;
        public int IdInquilino { get; private set; }
        public string Nome { get; set; }
        public int NIF { get; set; }
        public int Contato { get; set; }
        public string Endereco { get; set; }

        public Inquilino()
        {
            IdInquilino = proximoID++;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - NIF: {NIF}";
        }
    }
}