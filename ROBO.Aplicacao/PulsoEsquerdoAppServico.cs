using ROBO.Aplicacao.Interface;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Servico;

namespace ROBO.Aplicacao
{
    public class PulsoEsquerdoAppServico: AppServicoBase<Pulso, PulsoEstadoEnum>, IPulsoEsquerdoAppServico
    {
        private readonly IPulsoEsquerdoServico _pulsoEsquerdoServico;
        public PulsoEsquerdoAppServico(IPulsoEsquerdoServico pulsoEsquerdoServico)
            : base(pulsoEsquerdoServico)
        {
            _pulsoEsquerdoServico = pulsoEsquerdoServico;
        }
    }
}
