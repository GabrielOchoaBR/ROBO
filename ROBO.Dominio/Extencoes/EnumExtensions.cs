using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBO.Dominio.Extencoes
{
    public static class EnumExtensions
    {
        public static T Proximo<T>(this T src) where T : System.Enum
        {
            T[] Arr = (T[])Enum.GetValues(src.GetType());
            int j = Array.IndexOf<T>(Arr, src) + 1;
            return (Arr.Length == j) ? Arr[Arr.Length - 1] : Arr[j];
        }
        public static T Anterior<T>(this T src) where T : System.Enum
        {
            T[] Arr = (T[])Enum.GetValues(src.GetType());
            int j = Array.IndexOf<T>(Arr, src) - 1;
            return (j == -1) ? Arr[0] : Arr[j];
        }
    }
}
