using ROBO.Dominio.Interface.Validacoes.Auxiliares;

namespace ROBO.Dominio.Interface.Validacoes
{
    public interface IValidacaoBase<TClass, TFather> 
        where TClass : class
        where TFather : class
    {
        ValidacaoResultado Validar(TClass cClass, TFather cFather, string Key);
    }
}
