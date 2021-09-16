using System;


namespace ExcerciseExtensionMethods.Entities
{
    public class Logic
    {
        protected String[] Operations;
        public String message { get; protected set; }

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
            this.message = "Muy Bien";
            return true ;
         }

        public bool LockForOperations(int index, String message)
        {

            if (index < 0 || index > Operations.Length)
            {
                throw new MyExceptions(message);
            }
            this.message = "Correcto la operacion existe";
            return true;
        }

    }
}
