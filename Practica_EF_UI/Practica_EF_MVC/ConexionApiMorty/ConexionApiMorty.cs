using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Practica_EF_MVC.ConexionApiMorty
{
    public static class ConexionApiMorty
    {
        public static HttpWebRequest Conexion()
        {
                var url = $"https://rickandmortyapi.com/api/character";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";

            return request;
        }
    }
}