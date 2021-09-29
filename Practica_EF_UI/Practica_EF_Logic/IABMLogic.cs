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
        String Delete(T obj);

        List<T> GetAll();

        T GetById(T obj);

        String Insert(T obj);

        string Update(T obj);

    }
}
