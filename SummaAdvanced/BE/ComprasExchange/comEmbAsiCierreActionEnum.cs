using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 18 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comEmbAsiCierreActionEnum
        {            public enum EnumcomEmbAsiCierreAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomEmbAsiCierreAction(comEmbAsiCierreActionEnum.EnumcomEmbAsiCierreAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comEmbAsiCierreActionEnum.EnumcomEmbAsiCierreAction.Guardar: lRetorno = "comEmbAsiCierreGuardar"; break;
                case comEmbAsiCierreActionEnum.EnumcomEmbAsiCierreAction.Datos: lRetorno = "comEmbAsiCierreDevolverDatos"; break;
                case comEmbAsiCierreActionEnum.EnumcomEmbAsiCierreAction.Eliminar: lRetorno = "comEmbAsiCierreEliminar"; break;
            }
            return lRetorno;
        }
    }
}
