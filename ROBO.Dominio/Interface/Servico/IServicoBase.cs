using System;
namespace ROBO.Dominio.Interface.Servico
{
    public interface IServicoBase<TClass, TEnum> : IDisposable 
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
