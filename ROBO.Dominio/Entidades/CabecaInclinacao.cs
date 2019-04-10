namespace ROBO.Dominio.Entidades
{
    public class CabecaInclinacao : EstadoBase<CabecaInclinacaoEnum>
    {
        public CabecaInclinacao()
        {
            EstadoAtual = CabecaInclinacaoEnum.EmRepouso;
        }
    }
}
