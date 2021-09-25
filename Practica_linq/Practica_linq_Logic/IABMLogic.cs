using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_linq_Logic
{
    interface IABMLogic<T>
    {

        void Set_All_Acording_Region(String s);

        void Set_All_Acording_Unit_Stock(int x);

        String Get_IEnumerable_String(IEnumerable<T> customers);

        String Get_Object_String(T obj);

    }
}
