using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Practica_EF_MVC.Models;

namespace Practica_EF_MVC
{
    public static class ModelsMapHelpersMorty
    {
        public static List<CharactersView> MapCustomerToCustomerView(this JObject jsonResponse)
        {
            List<CharactersView> CharcterList = new List<CharactersView>();
            //foreach(var item in jsonResponse)
            //{
            //    var resultKey = item.Key;
            //    if(resultKey== "results")
            //    {
            //        foreach (var it in (item.Value[0]))
            //        {
            //            CharactersView cha =new  CharactersView();
            //            cha.id = (string)it[0];
            //            //cha.name = it[1].ToString();
            //            //cha.status = it[2].ToString();
            //            //cha.species = it[3].ToString();
            //            CharcterList.Add(cha);
            //        }

            //    }            
            //} 

            foreach (var item in jsonResponse)
            {
                var resultKey = item.Key;
                if (resultKey == "results")
                {
                    int cont= 0;
                    foreach (var _property in resultKey.GetType().GetProperties()
                     .Where(x => x.PropertyType == typeof(string)))
                    {
                        CharactersView cha = new CharactersView();
                         if (cont<4)
                        {

                            var prop = (_property.GetType().GetProperty(_property.Name));
                            prop.SetValue(_property, prop.GetValue(_property, null).ToString().ToUpper());
                            cha.id = prop.ToString();
                            cont++;
                        }

                        
                        CharcterList.Add(cha);
                    }
                }
                 
            }

            return CharcterList;
        }

    }
}
