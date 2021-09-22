using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Entities;

namespace Practica_EF_Logic
{
    interface IABMLogic<T>
    {
        void Delete(int id);
        List<T> GetAll();
        void GetByCodigo(string id);
        void GetById(int id);
        void Insert(Shippers newShiper);
        string Update(T c);

    }
}
