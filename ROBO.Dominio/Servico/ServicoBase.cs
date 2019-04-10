using System;
using ROBO.Dominio.Entidades;
using ROBO.Dominio.Interface.Entidades;
using ROBO.Dominio.Interface.Servico;
using ROBO.Dominio.Interface.Validacoes;

namespace ROBO.Dominio.Servico
{
    public abstract class ServicoBase<TClass, TEnum> : IServicoBase<TClass, TEnum>
        where TClass : EstadoBase<TEnum>
        where TEnum : Enum
    {
        private Robo _robo;
        private TClass _obj;
        private IValidacaoBase<TClass, Robo> _validador;
        private string _key;

        public ServicoBase(TClass obj, Robo robo, IValidacaoBase<TClass, Robo> validador, string key)
        {
            _obj = obj;
            _robo = robo;
            _validador = validador;
            _key = key;
        }

        public TClass Objeto()
        {
            return _obj;
        }

        public TEnum EstadoAtual()
        {
            return _obj.EstadoAtual;
        }

        public bool ProximoEstado()
        {
            if (_validador != null && !_validador.Validar(_obj, _robo, _key).Valido)
                return false;

            TEnum proximo = _obj.ProximoEstado;
            TEnum atual = _obj.EstadoAtual;

            if (atual.CompareTo(proximo) != 0)
            {
                _obj.EstadoAtual = proximo;

                return true;
            }
            return false;
        }
        public bool MudarEstado(TEnum estado)
        {
            if (_validador != null && !_validador.Validar(_obj, _robo, _key).Valido)
                return false;

            TEnum proximo = _obj.ProximoEstado;
            TEnum anterior = _obj.AnteriorEstado;

            if (anterior.CompareTo(estado) == 0 || proximo.CompareTo(estado) == 0)
            {
                _obj.EstadoAtual = estado;

                return true;
            }
            return false;
        }
        public bool AnteriorEstado()
        {
            if (_validador != null && !_validador.Validar(_obj, _robo, _key).Valido)
                return false;

            TEnum anterior = _obj.AnteriorEstado;
            TEnum atual = _obj.EstadoAtual;

            if (atual.CompareTo(anterior) != 0)
            {
                _obj.EstadoAtual = anterior;

                return true;
            }
            return false;
        }

        public void Dispose()
        { }
    }
}
