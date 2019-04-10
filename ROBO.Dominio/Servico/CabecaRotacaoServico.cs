using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Entidades;
using ROBO.Dominio.Interface.Servico;
using ROBO.Dominio.Validacoes.RegistrosValidacoes;

namespace ROBO.Dominio.Servico
{
    public class CabecaRotacaoServico : ServicoBase<CabecaRotacao, CabecaRotacaoEnum>, ICabecaRotacaoServico
    {
        public CabecaRotacaoServico(IRobo robo)
            : base(robo.Cabeca.CabecaRotacao, (Robo)robo, new CabecaValidacao(), "CabecaRotacao")
        {}
    }
}
