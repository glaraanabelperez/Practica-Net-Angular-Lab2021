using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using Newtonsoft.Json.Linq;
using Practica_EF_Logic.Practica.EF.Logic.APIMory;

namespace Practica_EF_Logic
{
    public static class HelpersMapJsonMorty
    {
        public static List<ModelApiMorty> SetCharactersOfJsonMorty(this string stringResponse)
        {
            List<ModelApiMorty> charcterList = new List<ModelApiMorty>();

            JArray jsonArray = JArray.Parse(stringResponse);
          
              for(var i=0; i< jsonArray.Children().ToList().Count; i++)
            {

                ModelApiMorty newChar = new ModelApiMorty();
                newChar.id = (int)jsonArray[i]["id"];
                newChar.name = (string)jsonArray[i]["name"];
                newChar.status = (string)jsonArray[i]["status"];
                newChar.species = (string)jsonArray[i]["species"];
                newChar.img = (string)jsonArray[i]["image"];
                charcterList.Add(newChar);
            }

            return charcterList;
        }
    }
}

