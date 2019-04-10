using System;
using ROBO.Aplicacao.Interface;
using ROBO.Dominio.Interface.Servico;

namespace ROBO.Aplicacao
{
    public class AppServicoBase<TClass, TEnum> : IAppServicoBase<TClass, TEnum>
        where TClass : class
        where TEnum : Enum
    {
        private readonly IServicoBase<TClass, TEnum> _ServiceBase;

        public AppServicoBase(IServicoBase<TClass, TEnum> serviceBase)
        {
            _ServiceBase = serviceBase;
        }

        public TClass Objeto() => _ServiceBase.Objeto();

        public TEnum EstadoAtual() => _ServiceBase.EstadoAtual();

        public bool ProximoEstado() => _ServiceBase.ProximoEstado();
        public bool MudarEstado(TEnum estado) => _ServiceBase.MudarEstado(estado);
        public bool AnteriorEstado() => _ServiceBase.AnteriorEstado();

        public void Dispose() => _ServiceBase.Dispose();
    }
}
