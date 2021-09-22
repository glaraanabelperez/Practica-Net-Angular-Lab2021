using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_EF_Logic.ExtensionMethodsLogic
{
    public static class ExceptionMethods
    {
        public static string ThrowingNulReference(this String entrie)
        {
            if (String.IsNullOrEmpty(entrie))
            {
                throw new NullReferenceException();
            }
            return entrie;

        }

    }
}
