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
        string Delete(int id);
        List<T> GetAll();
        void GetByCodigo(string id);
        void GetById(int id);
        string Update(T id);

    }
}
