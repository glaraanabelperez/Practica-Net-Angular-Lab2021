using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practica_EF_Logic.Practica.EF.Logic.APIMory
{
    public class ConexionApiMorty
    {
        public HttpWebRequest ConexionApi()
        {
            try
            {
                var url = $"https://rickandmortyapi.com/api/character/[1,2,3,4,5,6,7,8]";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";

                return request;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
