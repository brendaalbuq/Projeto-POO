using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalhoPOO_27209_Fase1.Class;

namespace trabalhoPOO_27209_Fase1.Class
{
    public class GerenciamentoFinanceiro
    {
        public List<Contrato> Contratos { get; private set; } = new List<Contrato>();
        public void AdicionarContrato(Contrato contrato)
        {
            Contratos.Add(contrato);
        }

        public bool ExcluirContrato(Imovel imovel, Inquilino inquilino, Proprietario proprietario)
        {
            var contrato = Contratos.FirstOrDefault(c =>
            c.Imovel.IdImovel == imovel.IdImovel &&
            c.Inquilino.Nome == inquilino.Nome &&
            c.Proprietario.Nome == proprietario.Nome
            );
            if (contrato != null)
            {
                Contratos.Remove(contrato);
                return true;
            }
            return false;
        }
        public void AlterarContrato(int idContrato, Contrato contratoAlterado)
        {
            var contrato = Contratos.FirstOrDefault(c => c.IdContrato == idContrato);
            if (contrato != null)
            {
                contrato.Imovel = contratoAlterado.Imovel;
                contrato.Inquilino = contratoAlterado.Inquilino;
                contrato.Proprietario = contratoAlterado.Proprietario;
                contrato.DataInicio = contratoAlterado.DataInicio;
                contrato.DataFim = contratoAlterado.DataFim;
                contrato.ValorAluguel = contratoAlterado.ValorAluguel;
                contrato.Ativo = contratoAlterado.Ativo;
            }
        }
        public List<Contrato> ListarContratos()
        {
            return Contratos;
        }
    }
}