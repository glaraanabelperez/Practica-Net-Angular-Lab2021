using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

            var titleProp = json.Children<JProperty>().LastOrDefault(z => z.Name == "results");
            if (titleProp != null)
            {
                var list=titleProp.ToList();
               
            }
            //foreach (JObject jsonCharacters in json.Children<JObject>())
            //{

            //}
            return charcterList;

        }
    }
}