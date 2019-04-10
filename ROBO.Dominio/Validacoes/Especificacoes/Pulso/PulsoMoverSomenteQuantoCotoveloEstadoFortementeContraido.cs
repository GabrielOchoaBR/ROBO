using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Validacoes;

namespace ROBO.Dominio.Validacoes.Especificacoes.Pulso
{
    public class PulsoMoverSomenteQuantoCotoveloEstadoFortementeContraido : IEspecificacao<Entidades.Pulso, Robo>
    {
        public bool Satisfeito(Entidades.Pulso TEntity, Robo TFather, string Key)
        {
            if (Key == "PulsoDireito")
                return (TFather.BracoDireito.Cotovelo.EstadoAtual == CotoveloEstadoEnum.FortementeContraido);
            else
                return (TFather.BracoEsquerdo.Cotovelo.EstadoAtual == CotoveloEstadoEnum.FortementeContraido);
        }
    }
}
