namespace ROBO.Dominio.Interface.Validacoes.Auxiliares
{
    public class ValidacaoResultado
    {
        public bool Valido => (string.IsNullOrEmpty(Mensagem));

        public string Mensagem { get; set; }
    }
}
