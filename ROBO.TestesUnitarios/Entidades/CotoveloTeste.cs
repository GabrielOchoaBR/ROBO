using Microsoft.VisualStudio.TestTools.UnitTesting;
using ROBO.Dominio.Entidades;

namespace ROBO.TestesUnitarios.Entidades
{
    [TestClass]
    public class CotoveloTeste
    {
        [TestMethod]
        [TestCategory("Entidade - Cotovelo")]
        public void Cotovelo_EstadoPadraoEmRepouso_RetornarVerdadeiro()
        {
            Cotovelo Cotovelo = new Cotovelo();

            CotoveloEstadoEnum Estado = Cotovelo.EstadoAtual;

            Assert.AreEqual(CotoveloEstadoEnum.EmRepouso, Estado);
        }

        [TestMethod]
        [TestCategory("Entidade - Cotovelo")]
        public void Cotovelo_ProximoEstadoDeveSerLevementeContraido_RetornarVerdadeiro()
        {
            Cotovelo Cotovelo = new Cotovelo();

            CotoveloEstadoEnum Estado = Cotovelo.ProximoEstado;

            Assert.AreEqual(CotoveloEstadoEnum.LevementeContraido, Estado);
        }

        [TestMethod]
        [TestCategory("Entidade - Cotovelo")]
        public void Cotovelo_AnteriorEstadoDeveSerEmRepouso_RetornarVerdadeiro()
        {
            Cotovelo Cotovelo = new Cotovelo();

            CotoveloEstadoEnum Estado = Cotovelo.AnteriorEstado;

            Assert.AreEqual(CotoveloEstadoEnum.EmRepouso, Estado);
        }
    }
}
