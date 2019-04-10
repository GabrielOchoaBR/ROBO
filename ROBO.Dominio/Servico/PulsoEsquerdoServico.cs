using ROBO.Dominio.Interface.Servico;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Entidades;
using ROBO.Dominio.Validacoes.RegistrosValidacoes;

namespace ROBO.Dominio.Servico
{
    public class PulsoEsquerdoServico : ServicoBase<Pulso, PulsoEstadoEnum>, IPulsoEsquerdoServico
    {
        public PulsoEsquerdoServico(IRobo robo)
            : base(robo.BracoEsquerdo.Pulso, (Robo)robo, new PulsoValidacao(), "PulsoEsquerdo")
        { }
    }
}
