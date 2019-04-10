using ROBO.Dominio.Entidades;
using ROBO.Dominio.Validacoes.Especificacoes.Pulso;

namespace ROBO.Dominio.Validacoes.RegistrosValidacoes
{
    public class PulsoValidacao : ValidacaoBase<Pulso, Robo>
    {
        public PulsoValidacao()
        {
            var PulsoMoverSomente = new PulsoMoverSomenteQuantoCotoveloEstadoFortementeContraido();

            base.AdicionarRegra("Pulso_Movimento_Invalido|Cotovelo_Estado_Diferente_FortementeContraido", PulsoMoverSomente);
        }
    }
}
