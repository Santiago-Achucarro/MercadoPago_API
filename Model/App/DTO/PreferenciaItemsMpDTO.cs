using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoPago_API.Model.System.DTO
{
    public class PreferenciaItemsMpDTO
    {
        public string NotificationUrl { get; set; }
        public List<ItemDTO> Items { get; set; }
    }
     public class ItemDTO
    {
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }

}
