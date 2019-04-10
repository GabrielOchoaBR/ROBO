using ROBO.Dominio.Extencoes;

namespace ROBO.Dominio.Entidades
{
    public class Cabeca
    {
        public CabecaInclinacao CabecaInclinacao { get; set; } = new CabecaInclinacao();

        public CabecaRotacao CabecaRotacao { get; set; } = new CabecaRotacao();
    }
}
