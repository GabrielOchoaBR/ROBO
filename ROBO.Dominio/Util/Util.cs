using System;

namespace ROBO.Dominio.Util
{
    public static class Util
    {
        public static TEnum ConversorStringParaEnum<TEnum>(string palavra) where TEnum : Enum
        {
            return (TEnum)Enum.Parse(typeof(TEnum), palavra, true);
        }
    }
}
