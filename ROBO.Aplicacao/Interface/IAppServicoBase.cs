using System;

namespace ROBO.Aplicacao.Interface
{
    public interface IAppServicoBase<TClass, TEnum> : IDisposable 
        where TClass : class
        where TEnum : Enum
    {
        TClass Objeto();
        TEnum EstadoAtual();
        bool ProximoEstado();
        bool AnteriorEstado();
        bool MudarEstado(TEnum estado);
    }
}
