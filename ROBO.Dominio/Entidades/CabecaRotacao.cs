namespace ROBO.Dominio.Entidades
{
    public class CabecaRotacao : EstadoBase<CabecaRotacaoEnum>
    {
        public CabecaRotacao()
        {
            EstadoAtual = CabecaRotacaoEnum.EmRepouso;
        }
    }
}
