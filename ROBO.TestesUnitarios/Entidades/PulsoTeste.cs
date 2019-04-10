using Microsoft.VisualStudio.TestTools.UnitTesting;
using ROBO.Dominio.Entidades;

namespace ROBO.TestesUnitarios.Entidades
{
    [TestClass]
    public class PulsoTeste
    {
        [TestMethod]
        [TestCategory("Entidade - Pulso")]
        public void Pulso_EstadoPadraoEmRepouso_RetornarVerdadeiro()
        {
            Pulso Pulso = new Pulso();

            PulsoEstadoEnum Estado = Pulso.EstadoAtual;

            Assert.AreEqual(PulsoEstadoEnum.EmRepouso, Estado);
        }

        [TestMethod]
        [TestCategory("Entidade - Pulso")]
        public void Pulso_ProximoEstadoDeveSerPos45_RetornarVerdadeiro()
        {
            Pulso Pulso = new Pulso();

            PulsoEstadoEnum Estado = Pulso.ProximoEstado;

            Assert.AreEqual(PulsoEstadoEnum.Pos_45, Estado);
        }

        [TestMethod]
        [TestCategory("Entidade - Pulso")]
        public void Pulso_AnteriorEstadoDeveSerNeg45_RetornarVerdadeiro()
        {
            Pulso Pulso = new Pulso();

            PulsoEstadoEnum Estado = Pulso.AnteriorEstado;

            Assert.AreEqual(PulsoEstadoEnum.Neg_45, Estado);
        }
    }
}
