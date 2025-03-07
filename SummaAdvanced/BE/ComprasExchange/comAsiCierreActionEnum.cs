using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 14 de octubre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comAsiCierreActionEnum
        {            public enum EnumcomAsiCierreAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomAsiCierreAction(comAsiCierreActionEnum.EnumcomAsiCierreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comAsiCierreActionEnum.EnumcomAsiCierreAction.Guardar: lRetorno = "comAsiCierreGuardar"; break;
                case comAsiCierreActionEnum.EnumcomAsiCierreAction.Datos: lRetorno = "comAsiCierreDevolverDatos"; break;
                case comAsiCierreActionEnum.EnumcomAsiCierreAction.Eliminar: lRetorno = "comAsiCierreEliminar"; break;
            }
            return lRetorno;
        }
    }
}
