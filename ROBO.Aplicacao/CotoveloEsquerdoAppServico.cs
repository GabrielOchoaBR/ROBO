using ROBO.Aplicacao.Interface;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Servico;

namespace ROBO.Aplicacao
{
    public class CotoveloEsquerdoAppServico : AppServicoBase<Cotovelo, CotoveloEstadoEnum>, ICotoveloEsquerdoAppServico
    {
        private readonly ICotoveloEsquerdoServico _cotoveloEsquerdoServico;
        public CotoveloEsquerdoAppServico(ICotoveloEsquerdoServico cotoveloEsquerdoServico)
            : base(cotoveloEsquerdoServico)
        {
            _cotoveloEsquerdoServico = cotoveloEsquerdoServico;
        }
    }
}
