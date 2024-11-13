using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalhoPOO_27209_Fase1.Class;

namespace trabalhoPOO_27209_Fase1.Class
{
    public static class DataStore
    {
        public static List<Imovel> Imoveis { get; } = new List<Imovel>();
        public static List<Inquilino> Inquilinos { get; } = new List<Inquilino>();
        public static List<Proprietario> Proprietarios { get; } = new List<Proprietario>();
        public static List<Contrato> Contratos { get; } = new List<Contrato>();
    }
}