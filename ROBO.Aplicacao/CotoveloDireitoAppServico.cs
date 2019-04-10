using ROBO.Aplicacao.Interface;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Servico;

namespace ROBO.Aplicacao
{
    public class CotoveloDireitoAppServico : AppServicoBase<Cotovelo, CotoveloEstadoEnum>, ICotoveloDireitoAppServico
    {
        private readonly ICotoveloDireitoServico _cotoveloDireitoServico;
        public CotoveloDireitoAppServico(ICotoveloDireitoServico cotoveloDireitoServico)
            : base(cotoveloDireitoServico)
        {
            _cotoveloDireitoServico = cotoveloDireitoServico;
        }
    }
}
