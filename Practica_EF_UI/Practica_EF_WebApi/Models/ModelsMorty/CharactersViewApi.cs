using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica_EF_WebApi.Models
{
    public class CharactersViewApi
    {
        public int id { get; set; }

        public string name { get; set; }

        public string status { get; set; }

        public string species { get; set; }

        public string img { get; set; }

        public CharactersViewApi(){}

  
    }
}