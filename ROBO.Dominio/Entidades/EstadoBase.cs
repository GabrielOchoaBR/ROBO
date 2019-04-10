using ROBO.Dominio.Extencoes;

namespace ROBO.Dominio.Entidades
{
    public abstract class EstadoBase<TEnum> where TEnum : System.Enum
    {
        public TEnum EstadoAtual { get; internal set; }
        public TEnum ProximoEstado
        {
            get { return EstadoAtual.Proximo(); }
        }
        public TEnum AnteriorEstado
        {
            get { return EstadoAtual.Anterior(); }
        }
    }
}
