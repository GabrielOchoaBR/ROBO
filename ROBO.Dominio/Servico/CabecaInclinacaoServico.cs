using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Entidades;
using ROBO.Dominio.Interface.Servico;

namespace ROBO.Dominio.Servico
{
    public class CabecaInclinacaoServico : ServicoBase<CabecaInclinacao, CabecaInclinacaoEnum>, ICabecaInclinacaoServico
    {
        public CabecaInclinacaoServico(IRobo robo)
            : base(robo.Cabeca.CabecaInclinacao, (Robo)robo, null, string.Empty)
        {}
    }
}
