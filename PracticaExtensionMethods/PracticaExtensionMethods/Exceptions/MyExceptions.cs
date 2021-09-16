using System;


namespace ExcerciseExtensionMethods.Entities
{
    class MyExceptions:Exception
    {
        public MyExceptions(String message) : base("No existe la operacion:  " + message)
        {

        }
    }
}
