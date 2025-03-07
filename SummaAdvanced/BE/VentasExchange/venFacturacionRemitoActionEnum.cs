using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 20 de mayo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venFacturacionRemitoActionEnum
        {            public enum EnumvenFacturacionRemitoAction
            {
                Datos, AsignarCambio
        }
        public static string GetAccionvenFacturacionRemitoAction(venFacturacionRemitoActionEnum.EnumvenFacturacionRemitoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venFacturacionRemitoActionEnum.EnumvenFacturacionRemitoAction.Datos: lRetorno = "venFacturacionRemitoDevolverDatos"; break;
                case venFacturacionRemitoActionEnum.EnumvenFacturacionRemitoAction.AsignarCambio: lRetorno = "venFacturacionRemitoAsignarCambio"; break;
            }
            return lRetorno;
        }
    }
}
