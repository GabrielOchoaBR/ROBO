using ROBO.Dominio.Interface.Servico;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Entidades;

namespace ROBO.Dominio.Servico
{
    public class CotoveloDireitoServico : ServicoBase<Cotovelo, CotoveloEstadoEnum>, ICotoveloDireitoServico
    {
        public CotoveloDireitoServico(IRobo robo)
            : base(robo.BracoDireito.Cotovelo, (Robo)robo, null, string.Empty)
        { }
    }
}
