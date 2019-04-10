using ROBO.Dominio.Extencoes;

namespace ROBO.Dominio.Entidades
{
    public class Pulso : EstadoBase<PulsoEstadoEnum>
    {
        public Pulso()
        {
            EstadoAtual = PulsoEstadoEnum.EmRepouso;
        }
    }
}