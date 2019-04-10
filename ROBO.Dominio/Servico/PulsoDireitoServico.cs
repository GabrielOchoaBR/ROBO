using ROBO.Dominio.Interface.Servico;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Entidades;
using ROBO.Dominio.Validacoes.RegistrosValidacoes;

namespace ROBO.Dominio.Servico
{
    public class PulsoDireitoServico : ServicoBase<Pulso, PulsoEstadoEnum>, IPulsoDireitoServico
    {
        public PulsoDireitoServico(IRobo robo)
            : base(robo.BracoDireito.Pulso, (Robo)robo, new PulsoValidacao(), "PulsoDireito")
        { }
    }
}
