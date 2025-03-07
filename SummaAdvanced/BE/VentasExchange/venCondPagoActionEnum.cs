using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCondPagoActionEnum
        {            public enum EnumvenCondPagoAction
            {
                Guardar,Datos,Eliminar,DatosXDias
            }
        public static string GetAccionvenCondPagoAction(venCondPagoActionEnum.EnumvenCondPagoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCondPagoActionEnum.EnumvenCondPagoAction.Guardar: lRetorno = "venCondPagoGuardar"; break;
                case venCondPagoActionEnum.EnumvenCondPagoAction.Datos: lRetorno = "venCondPagoDevolverDatos"; break;
                case venCondPagoActionEnum.EnumvenCondPagoAction.Eliminar: lRetorno = "venCondPagoEliminar"; break;
                case venCondPagoActionEnum.EnumvenCondPagoAction.DatosXDias: lRetorno = "venCondPagoDatosXDias"; break;
            }
            return lRetorno;
        }
    }
}
