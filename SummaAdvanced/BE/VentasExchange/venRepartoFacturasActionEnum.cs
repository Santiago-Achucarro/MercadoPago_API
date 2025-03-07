using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venRepartoFacturasActionEnum
        {            public enum EnumvenRepartoFacturasAction
            {
                Datos
            }
        public static string GetAccionvenRepartoFacturasAction(venRepartoFacturasActionEnum.EnumvenRepartoFacturasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venRepartoFacturasActionEnum.EnumvenRepartoFacturasAction.Datos: lRetorno = "venRepartoFacturasDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
