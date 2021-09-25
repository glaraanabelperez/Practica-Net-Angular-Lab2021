using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_linq_Logic.Dto_Logic
{
    public class CustomersDto : CustomersLogic
    {
        public String CompanyName;
        public String ContactName;
        public String Region;
        public DateTime OrderDate;
        public String OrderId;

        public List<OrdresDto> Order_logic;

    }
}
