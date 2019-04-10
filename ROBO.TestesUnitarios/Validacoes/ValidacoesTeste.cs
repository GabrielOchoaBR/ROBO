using System.Net.Http.Headers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Validacoes.Auxiliares;
using ROBO.Dominio.Validacoes.RegistrosValidacoes;

namespace ROBO.TestesUnitarios.Validacoes
{
    [TestClass]
    public class ValidacoesTeste
    {
        [TestMethod]
        [TestCategory("Validacao - Pulso")]
        //Só poderá movimentar o Pulso caso o Cotovelo esteja Fortemente Contraído.
        public void PulsoMovimentar_MovimentarPulsoComCotoveloEmRepouso_RetornarFalso()
        {
            Robo Robo = JsonConvert.DeserializeObject<Robo>("{ \"Cabeca\": { \"CabecaInclinacao\": { \"EstadoAtual\": 1, \"ProximoEstado\": 2, \"AnteriorEstado\": 0 }, \"CabecaRotacao\": { \"EstadoAtual\": 2, \"ProximoEstado\": 3,\"AnteriorEstado\": 1 } }, \"BracoEsquerdo\": { \"Cotovelo\": { \"EstadoAtual\": 0, \"ProximoEstado\": 1, \"AnteriorEstado\": 0 }, \"Pulso\": { \"EstadoAtual\": 2, \"ProximoEstado\": 3, \"AnteriorEstado\": 1 } }, \"BracoDireito\": { \"Cotovelo\": { \"EstadoAtual\": 0, \"ProximoEstado\": 1, \"AnteriorEstado\": 0 }, \"Pulso\": { \"EstadoAtual\": 2, \"ProximoEstado\": 3, \"AnteriorEstado\": 1 } } }");

            PulsoValidacao PulsoValidacao = new PulsoValidacao();

            ValidacaoResultado Retorno = PulsoValidacao.Validar(Robo.BracoDireito.Pulso, Robo, "PulsoDireito");

            Assert.AreEqual(false, Retorno.Valido);
        }

        [TestMethod]
        [TestCategory("Validacao - Cabeca Rotacao")]
        //Só poderá Rotacionar a Cabeça caso sua Inclinação da Cabeça não esteja em estado Para Baixo. 
        public void CabecaRotacao_RotacionarCabecaCasoInclinacaoNaoSejaParaBaixo_RetornarVerdadeiro()
        {
            Robo Robo = JsonConvert.DeserializeObject<Robo>("{ \"Cabeca\": { \"CabecaInclinacao\": { \"EstadoAtual\": 1, \"ProximoEstado\": 2, \"AnteriorEstado\": 0 }, \"CabecaRotacao\": { \"EstadoAtual\": 2, \"ProximoEstado\": 3,\"AnteriorEstado\": 1 } }, \"BracoEsquerdo\": { \"Cotovelo\": { \"EstadoAtual\": 0, \"ProximoEstado\": 1, \"AnteriorEstado\": 0 }, \"Pulso\": { \"EstadoAtual\": 2, \"ProximoEstado\": 3, \"AnteriorEstado\": 1 } }, \"BracoDireito\": { \"Cotovelo\": { \"EstadoAtual\": 1, \"ProximoEstado\": 2, \"AnteriorEstado\": 0 }, \"Pulso\": { \"EstadoAtual\": 2, \"ProximoEstado\": 3, \"AnteriorEstado\": 1 } } }");

            CabecaValidacao CabecaRotacaoValidacao = new CabecaValidacao();

            ValidacaoResultado Retorno = CabecaRotacaoValidacao.Validar(Robo.Cabeca.CabecaRotacao, Robo, "CabecaRotacao");

            Assert.AreEqual(true, Retorno.Valido);
        }

    }
}
