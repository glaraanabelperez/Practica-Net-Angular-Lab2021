using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_linq_Logic.Helperes_Logic
{
    public static class Helpers_Logic
    {
        public static string Convert_ToUper_AndLower(this String name)
        {
            String convertName = $"Mayuscula: {name.ToUpper()}, Minuscula: {name.ToLower()}";
            return convertName;
        }
    }
}
