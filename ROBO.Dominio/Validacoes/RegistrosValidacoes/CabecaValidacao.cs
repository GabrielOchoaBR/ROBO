using ROBO.Dominio.Entidades;
using ROBO.Dominio.Validacoes.Especificacoes.CabecaRotacao;

namespace ROBO.Dominio.Validacoes.RegistrosValidacoes
{
    public class CabecaValidacao : ValidacaoBase<CabecaRotacao, Robo>
    {
        public CabecaValidacao()
        {
            var CabecaRotacaoSomente = new CabecaRotacaoSomenteQuantoInclinacaoNaoParaBaixo();

            base.AdicionarRegra("Cabeca_Movimento_Invalido|CabecaInclinacao_Igual_ParaBaixo", CabecaRotacaoSomente);
        }
    }
}
