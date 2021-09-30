using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;

namespace Practica_EF_Dto
{
    public class Custom_New_Dto 
    {
        public Custom_New_Dto()
        {
        }
        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string Country { get; set; }
    }
}