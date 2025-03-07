using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 14 de octubre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comAsiCierreCrActionEnum
        {            public enum EnumcomAsiCierreCrAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomAsiCierreCrAction(comAsiCierreCrActionEnum.EnumcomAsiCierreCrAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comAsiCierreCrActionEnum.EnumcomAsiCierreCrAction.Guardar: lRetorno = "comAsiCierreCrGuardar"; break;
                case comAsiCierreCrActionEnum.EnumcomAsiCierreCrAction.Datos: lRetorno = "comAsiCierreCrDevolverDatos"; break;
                case comAsiCierreCrActionEnum.EnumcomAsiCierreCrAction.Eliminar: lRetorno = "comAsiCierreCrEliminar"; break;
            }
            return lRetorno;
        }
    }
}
