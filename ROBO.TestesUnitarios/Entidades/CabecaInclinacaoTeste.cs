using Microsoft.VisualStudio.TestTools.UnitTesting;
using ROBO.Dominio.Entidades;

namespace ROBO.TestesUnitarios.Entidades
{
    [TestClass]
    public class CabecaInclinacaoTeste
    {
        [TestMethod]
        [TestCategory("Entidade - Cabeca Inclinacao")]
        public void CabecaInclinacao_EstadoPadraoEmRepouso_RetornarVerdadeiro()
        {
            CabecaInclinacao CabecaInclinacao = new CabecaInclinacao();

            CabecaInclinacaoEnum Estado = CabecaInclinacao.EstadoAtual;

            Assert.AreEqual(CabecaInclinacaoEnum.EmRepouso, Estado);
        }

        [TestMethod]
        [TestCategory("Entidade - Cabeca Inclinacao")]
        public void CabecaInclinacao_ProximoEstadoDeveSerParaBaixo_RetornarVerdadeiro()
        {
            CabecaInclinacao CabecaInclinacao = new CabecaInclinacao();

            CabecaInclinacaoEnum Estado = CabecaInclinacao.ProximoEstado;

            Assert.AreEqual(CabecaInclinacaoEnum.ParaBaixo, Estado);
        }

        [TestMethod]
        [TestCategory("Entidade - Cabeca Inclinacao")]
        public void CabecaInclinacao_AnteriorEstadoDeveSerParaCima_RetornarVerdadeiro()
        {
            CabecaInclinacao CabecaInclinacao = new CabecaInclinacao();

            CabecaInclinacaoEnum Estado = CabecaInclinacao.AnteriorEstado;

            Assert.AreEqual(CabecaInclinacaoEnum.ParaCima, Estado);
        }
    }
}
