using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Practica_EF_MVC.Models;

namespace Practica_EF_MVC
{
    public static class ModelsMapHelpersMorty
    {
        public static List<CharactersView> MapCustomerToCustomerView(this string stringResponse)
        {
            List<CharactersView> charcterList = new List<CharactersView>();
           
            JObject json = JObject.Parse(stringResponse);
            //JSONArray contacts = json.getJSONArray("results");

            foreach (JObject jsonCharacters in json.Children<JObject>())
            {
                foreach (JProperty jsonChar in jsonCharacters.Properties())
                {
                    string CharResult = jsonChar.Name;
                    if (CharResult.Equals("results"))
                    {
                        CharactersView charView = new CharactersView();
                        var id = Convert.ToString(jsonCharacters["id"]);
                        charView.id = id;
                        charcterList.Add(charView);
                    }
                }

            }



            return charcterList;
        }

    }
}
