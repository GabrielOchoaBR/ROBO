using ROBO.Dominio.Entidades;

namespace ROBO.Dominio.Interface.Entidades
{
    public interface IRobo
    {
        Cabeca Cabeca { get; set; }
        Braco BracoEsquerdo { get; set; }
        Braco BracoDireito { get; set; }
    }
}
