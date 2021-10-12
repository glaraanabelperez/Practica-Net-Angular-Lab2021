using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Practica_EF_Logic.Practica.EF.Logic.APIMory;
using Practica_EF_MVC.Models;

namespace Practica_EF_MVC
{
    public static class ModelsMapHelpersMorty
    {
        public static List<CharactersView> SetCharactersViewOfJsonMorty(this string stringResponse)
        {
            List<CharactersView> charcterList = new List<CharactersView>();

            //"image": "https://rickandmortyapi.com/api/character/avatar/361.jpeg",
            JArray jsonArray = JArray.Parse(stringResponse);
            //charcterList=JsonConvert.DeserializeObject<CharactersView>(jsonArray);

            //foreach (var ch in jsonArray.Children().ToList())
            //{
              for(var i=0; i< jsonArray.Children().ToList().Count; i++)
            { 

                CharactersView newChar = new CharactersView();
                newChar.id = (int)jsonArray[i]["id"];
                newChar.name = (string)jsonArray[i]["name"];
                newChar.status = (string)jsonArray[i]["status"];
                newChar.species = (string)jsonArray[i]["species"];
                newChar.img = (string)jsonArray[i]["image"];
                charcterList.Add(newChar);
            }

            return charcterList;
        }

        //public static List<CharactersView> MapListModelMortyToViewMorty(this List<ModelApiMorty> modelApi)
        //{
        //    List<CharactersView> chView = new List<CharactersView>();

        //    foreach (var chList in modelApi)
        //    {
        //        CharactersView chNew = new CharactersView();
        //        chNew.id = chList.id;
        //        chNew.name = chList.name;
        //        chNew.status = chList.status;
        //        chNew.species = chList.species;
        //        chNew.img = chList.img;
        //    }

        //    return chView;
        //}
    }
}

