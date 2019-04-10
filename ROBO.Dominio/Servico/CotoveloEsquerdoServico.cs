using ROBO.Dominio.Interface.Servico;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Entidades;
using ROBO.Dominio.Validacoes;
using ROBO.Dominio.Validacoes.RegistrosValidacoes;

namespace ROBO.Dominio.Servico
{
    public class CotoveloEsquerdoServico : ServicoBase<Cotovelo, CotoveloEstadoEnum>, ICotoveloEsquerdoServico
    {
        public CotoveloEsquerdoServico(IRobo robo)
            : base(robo.BracoEsquerdo.Cotovelo, (Robo)robo, null, string.Empty)
        {
        }
    }
}
