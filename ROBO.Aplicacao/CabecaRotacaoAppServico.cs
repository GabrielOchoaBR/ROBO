using ROBO.Aplicacao.Interface;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Servico;

namespace ROBO.Aplicacao
{
    public class CabecaRotacaoAppServico: AppServicoBase<CabecaRotacao, CabecaRotacaoEnum>, ICabecaRotacaoAppServico
    {
        public CabecaRotacaoAppServico(ICabecaRotacaoServico cabecaRotacaoServico)
            : base(cabecaRotacaoServico)
        { }
    }
}
