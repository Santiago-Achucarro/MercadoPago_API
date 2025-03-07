using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venRegionActionEnum
        {            public enum EnumvenRegionAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenRegionAction(venRegionActionEnum.EnumvenRegionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venRegionActionEnum.EnumvenRegionAction.Guardar: lRetorno = "venRegionGuardar"; break;
                case venRegionActionEnum.EnumvenRegionAction.Datos: lRetorno = "venRegionDevolverDatos"; break;
                case venRegionActionEnum.EnumvenRegionAction.Eliminar: lRetorno = "venRegionEliminar"; break;
            }
            return lRetorno;
        }
    }
}
