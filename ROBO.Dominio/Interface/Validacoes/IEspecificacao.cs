namespace ROBO.Dominio.Interface.Validacoes
{
    public interface IEspecificacao<TEntity, TFather>
    {
        bool Satisfeito(TEntity entity, TFather father, string key);
    }
}
