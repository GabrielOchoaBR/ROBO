using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Validacoes;

namespace ROBO.Dominio.Validacoes.Especificacoes.CabecaRotacao
{
    public class CabecaRotacaoSomenteQuantoInclinacaoNaoParaBaixo : IEspecificacao<Entidades.CabecaRotacao, Robo>
    {
        public bool Satisfeito(Entidades.CabecaRotacao TEntity, Robo TFather, string Key)
        {
            return (TFather.Cabeca.CabecaInclinacao.EstadoAtual != CabecaInclinacaoEnum.ParaBaixo);
        }
    }
}
