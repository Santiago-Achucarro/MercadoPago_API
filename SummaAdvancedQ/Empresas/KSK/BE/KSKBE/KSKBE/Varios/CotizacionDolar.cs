using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSKBE.Varios
{
    public static class CotizacionDolar
    {
        private  static decimal cotizacion = 1;
    
        public  static decimal TraerCotizacion()
        {
            cotizacion = 1;
            ConectarSQL conectar = new ConectarSQL();
            DataTable tabla = conectar.EjecutarConsulta($@"select top 1 CambioVenta 
                            from genTipoCambio where Moneda_Id = 2 order by Fecha desc");

            if (tabla.Rows.Count > 0)
            {
                cotizacion = Convert.ToDecimal(tabla.Rows[0][0]);
            }
            return cotizacion;
        }

    }
}
