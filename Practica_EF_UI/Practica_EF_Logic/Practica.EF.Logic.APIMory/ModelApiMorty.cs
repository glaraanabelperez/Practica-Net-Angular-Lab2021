using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_EF_Logic.Practica.EF.Logic.APIMory
{
    public class ModelApiMorty
    {
        public int id { get; set; }

        public string name { get; set; }

        public string status { get; set; }

        public string species { get; set; }

        public string img { get; set; }

        public ModelApiMorty() { }

    }
}
