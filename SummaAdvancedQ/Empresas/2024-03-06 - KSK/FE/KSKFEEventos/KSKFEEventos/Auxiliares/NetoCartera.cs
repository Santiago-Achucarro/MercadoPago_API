using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSKFEEventos.Auxiliares
{
    public class NetoCartera
    {
        public string Cartera_Id { get; set; }
        public decimal Importe { get; set; }
    }

    public static class NetosFactura
    {
        public static decimal Importe;
        public static List<NetoCartera> Carteras = new List<NetoCartera>();
    }

}
