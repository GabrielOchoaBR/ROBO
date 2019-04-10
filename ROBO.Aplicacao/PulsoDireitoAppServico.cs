using ROBO.Aplicacao.Interface;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Servico;

namespace ROBO.Aplicacao
{
    public class PulsoDireitoAppServico : AppServicoBase<Pulso, PulsoEstadoEnum>, IPulsoDireitoAppServico
    {
        private readonly IPulsoDireitoServico _pulsoDireitoServico;
        public PulsoDireitoAppServico(IPulsoDireitoServico pulsoDireitoServico)
            : base(pulsoDireitoServico)
        {
            _pulsoDireitoServico = pulsoDireitoServico;
        }
    }
}
