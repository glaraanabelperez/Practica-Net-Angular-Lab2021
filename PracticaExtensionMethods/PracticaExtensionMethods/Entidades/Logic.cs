using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExtensionMethods.Entidades
{
    public class Logic
    {
        protected String[] Operations;

        public Logic()
        {
            this.Operations = new String[] { "suma", "resta", "division" };
        }

        public bool LockForOperations(int index)
        {

            if(index<0 || index > Operations.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return true ;
         }

        public bool LockForOperations(int index, String message)
        {

            if (index < 0 || index > Operations.Length)
            {
                throw new MyExceptioncs(message);
            }
            return true;
        }

    }
}
