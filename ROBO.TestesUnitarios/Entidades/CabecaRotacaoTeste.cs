using Microsoft.VisualStudio.TestTools.UnitTesting;
using ROBO.Dominio.Entidades;

namespace ROBO.TestesUnitarios.Entidades
{
    [TestClass]
    public class CabecaRotacaoTeste
    {
        [TestMethod]
        [TestCategory("Entidade - Cabeca Rotacao")]
        public void CabecaRotacao_EstadoPadraoEmRepouso_RetornarVerdadeiro()
        {
            CabecaRotacao CabecaRotacao = new CabecaRotacao();

            CabecaRotacaoEnum Estado = CabecaRotacao.EstadoAtual;

            Assert.AreEqual(CabecaRotacaoEnum.EmRepouso, Estado);
        }

        [TestMethod]
        [TestCategory("Entidade - Cabeca Rotacao")]
        public void CabecaRotacao_ProximoEstadoDeveSerPos45_RetornarVerdadeiro()
        {
            CabecaRotacao CabecaRotacao = new CabecaRotacao();

            CabecaRotacaoEnum Estado = CabecaRotacao.ProximoEstado;

            Assert.AreEqual(CabecaRotacaoEnum.Pos_45, Estado);
        }

        [TestMethod]
        [TestCategory("Entidade - Cabeca Rotacao")]
        public void CabecaRotacao_AnteriorEstadoDeveSerNeg45_RetornarVerdadeiro()
        {
            CabecaRotacao CabecaRotacao = new CabecaRotacao();

            CabecaRotacaoEnum Estado = CabecaRotacao.AnteriorEstado;

            Assert.AreEqual(CabecaRotacaoEnum.Neg_45, Estado);
        }
    }
}
