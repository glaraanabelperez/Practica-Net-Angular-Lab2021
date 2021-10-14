using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practica_EF_MVC.Models
{
    public class CustomerView
    {    
        public string CustomerID { get; set; }

        [Required, StringLength(15, MinimumLength = 3)]
        public string CompanyName { get; set; }

        [Required, StringLength(15, MinimumLength = 3)]
        public string ContactName { get; set; }

        [Required, StringLength(15, MinimumLength = 2)]
        public string Country { get; set; }



    }
}