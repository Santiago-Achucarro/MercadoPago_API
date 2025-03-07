using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 13 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkUbicacionesActionEnum
        {            public enum EnumstkUbicacionesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkUbicacionesAction(stkUbicacionesActionEnum.EnumstkUbicacionesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkUbicacionesActionEnum.EnumstkUbicacionesAction.Guardar: lRetorno = "stkUbicacionesGuardar"; break;
                case stkUbicacionesActionEnum.EnumstkUbicacionesAction.Datos: lRetorno = "stkUbicacionesDevolverDatos"; break;
                case stkUbicacionesActionEnum.EnumstkUbicacionesAction.Eliminar: lRetorno = "stkUbicacionesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
