using ROBO.Dominio.Interface.Entidades;

namespace ROBO.Dominio.Entidades
{
    public class Robo : IRobo
    {
        public Cabeca Cabeca { get; set; } = new Cabeca();

        public Braco BracoEsquerdo { get; set; } = new Braco();

        public Braco BracoDireito { get; set; } = new Braco();
    }
}
