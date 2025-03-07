using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 2 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comConPagoActionEnum
        {            public enum EnumcomConPagoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomConPagoAction(comConPagoActionEnum.EnumcomConPagoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comConPagoActionEnum.EnumcomConPagoAction.Guardar: lRetorno = "comConPagoGuardar"; break;
                case comConPagoActionEnum.EnumcomConPagoAction.Datos: lRetorno = "comConPagoDevolverDatos"; break;
                case comConPagoActionEnum.EnumcomConPagoAction.Eliminar: lRetorno = "comConPagoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
