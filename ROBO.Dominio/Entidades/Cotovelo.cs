namespace ROBO.Dominio.Entidades
{
    public class Cotovelo : EstadoBase<CotoveloEstadoEnum>
    {
        public Cotovelo()
        {
            EstadoAtual = CotoveloEstadoEnum.EmRepouso;
        }
    }
}