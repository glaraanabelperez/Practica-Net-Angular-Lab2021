using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json.Linq;
using Practica_EF_WebApi.Models;

namespace Practica_EF_WebApi
{
    public static class ModelsMapHelpersMorty
    {
        public static List<CharactersViewApi> SetCharactersViewOfJsonMorty(this string stringResponse)
        {
            List<CharactersViewApi> charcterList = new List<CharactersViewApi>();
            JArray jsonArray = JArray.Parse(stringResponse);

            for (var i = 0; i < jsonArray.Children().ToList().Count; i++)
            {

                CharactersViewApi newChar = new CharactersViewApi();
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