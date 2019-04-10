using ROBO.Aplicacao.Interface;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Servico;

namespace ROBO.Aplicacao
{
    public class CabecaInclinacaoAppServico: AppServicoBase<CabecaInclinacao, CabecaInclinacaoEnum>, ICabecaInclinacaoAppServico
    {
        private readonly ICabecaInclinacaoServico _cabecaInclicanacaoServico;
        public CabecaInclinacaoAppServico(ICabecaInclinacaoServico cabecaInclicanacaoServico)
            : base(cabecaInclicanacaoServico)
        {
            _cabecaInclicanacaoServico = cabecaInclicanacaoServico;
        }
    }
}
