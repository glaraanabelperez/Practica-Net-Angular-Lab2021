using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Practica_EF_Logic.Practica.EF.Logic.APIMory
{
    public class ApiMortyLogic 
    {
        ConexionApiMorty conexion;
        public ApiMortyLogic()
        {
            conexion = new ConexionApiMorty();
        }

        public List<ModelApiMorty> RequestDataApiMorty()
        {
            HttpWebRequest request;
            List<ModelApiMorty> listChar;
            try
            {
                request = conexion.ConexionApi();
                using (WebResponse response = request.GetResponse())
                {
                    try
                    {
                        using (Stream strReader = response.GetResponseStream())
                        {
                                using (StreamReader objReader = new StreamReader(strReader))
                                {
                                    string responseBody = objReader.ReadToEnd();
                                    listChar = responseBody.SetCharactersOfJsonMorty();
                                    return listChar;
                                }
                        }
                    }
                    catch (NotSupportedException e)
                    {
                        throw e;
                    }
                }
            }
            catch (WebException e)
            {
                throw e;
            }

        }
    }
}