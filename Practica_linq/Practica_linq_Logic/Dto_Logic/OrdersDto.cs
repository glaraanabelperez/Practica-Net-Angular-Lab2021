using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_linq_Logic.Dto_Logic
{
    public class OrdresDto : OrdersLogic
    {
        public int OrderId;
        public string CustomerID;

        List<OrderDetailsDto> Order_details_dto;
    }
}
