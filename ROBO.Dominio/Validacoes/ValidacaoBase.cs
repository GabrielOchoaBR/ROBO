using ROBO.Dominio.Interface.Validacoes;
using ROBO.Dominio.Interface.Validacoes.Auxiliares;
using System.Collections.Generic;

namespace ROBO.Dominio.Validacoes
{
    public class ValidacaoBase<TEntity, TFather> : IValidacaoBase<TEntity, TFather> 
        where TEntity : class
        where TFather : class
    {
        private readonly Dictionary<string, IEspecificacao<TEntity, TFather>> _validations = new Dictionary<string, IEspecificacao<TEntity, TFather>>();

        protected virtual void AdicionarRegra(string nomeRegra, IEspecificacao<TEntity, TFather> rule)
        {
            _validations.Add(nomeRegra, rule);
        }

        protected virtual void RemoverRegra(string nomeRegra)
        {
            _validations.Remove(nomeRegra);
        }

        protected IEspecificacao<TEntity, TFather> ObterRegra(string nomeRegra)
        {
            IEspecificacao<TEntity, TFather> rule;
            _validations.TryGetValue(nomeRegra, out rule);
            return rule;
        }

        public ValidacaoResultado Validar(TEntity entity, TFather father, string key)
        {
            var resultado = new ValidacaoResultado(); 

            foreach (var x in _validations.Keys)
            {
                var rule = _validations[x];
                if (!rule.Satisfeito(entity, father, key)) { 
                    resultado.Mensagem = x;
                    break;
                }
            }

            return resultado;
        }

    }
}
