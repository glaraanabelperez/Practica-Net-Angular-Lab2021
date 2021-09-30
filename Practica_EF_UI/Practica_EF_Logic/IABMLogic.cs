using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Dto;
using Practica_EF_Entities;

namespace Practica_EF_Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        T GetById(String obj);
        T GetById(int obj);
        T Delete(T obj);
        string Insert(T obj);
        string Update(T obj);
    }
}
