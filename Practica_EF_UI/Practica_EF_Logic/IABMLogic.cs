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
        string Delete(string obj);

        string Delete(int obj);

        List<T> GetAll();

        T GetById(string id);

        T GetById(int id);

        string Insert(T obj);

        string Update(T obj);

    }
}

