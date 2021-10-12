using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Practica_EF_Logic.Practica.EF.Logic.APIMory
{
    public class ApiMortyLogic 
    {
        public string RequestDataApiMorty()
        {
            try
            {
                var url = $"https://rickandmortyapi.com/api/character/[1,2,3,4,5,6,7,8]";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";
                try
                {
                    using (WebResponse response = request.GetResponse())
                    {
                        using (Stream strReader = response.GetResponseStream())
                        {
                            if (strReader == null) return "Request Vacia";

                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                return responseBody;
                            }
                        }
                    }
                }
                catch (WebException e)
                {
                    throw e;
                }

            }
            catch (ArgumentNullException e)
            {
                throw e;
            }
            catch(UriFormatException e){
                throw e;
            }
           
        }
    }
}