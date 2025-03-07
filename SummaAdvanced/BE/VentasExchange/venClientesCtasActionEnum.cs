using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 20 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venClientesCtasActionEnum
        {            public enum EnumvenClientesCtasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenClientesCtasAction(venClientesCtasActionEnum.EnumvenClientesCtasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venClientesCtasActionEnum.EnumvenClientesCtasAction.Guardar: lRetorno = "venClientesCtasGuardar"; break;
                case venClientesCtasActionEnum.EnumvenClientesCtasAction.Datos: lRetorno = "venClientesCtasDevolverDatos"; break;
                case venClientesCtasActionEnum.EnumvenClientesCtasAction.Eliminar: lRetorno = "venClientesCtasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
