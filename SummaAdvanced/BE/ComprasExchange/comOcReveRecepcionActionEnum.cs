using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 11 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comOcReveRecepcionActionEnum
        {            public enum EnumcomOcReveRecepcionAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomOcReveRecepcionAction(comOcReveRecepcionActionEnum.EnumcomOcReveRecepcionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOcReveRecepcionActionEnum.EnumcomOcReveRecepcionAction.Guardar: lRetorno = "comOcReveRecepcionGuardar"; break;
                case comOcReveRecepcionActionEnum.EnumcomOcReveRecepcionAction.Datos: lRetorno = "comOcReveRecepcionDevolverDatos"; break;
                case comOcReveRecepcionActionEnum.EnumcomOcReveRecepcionAction.Eliminar: lRetorno = "comOcReveRecepcionEliminar"; break;
            }
            return lRetorno;
        }
    }
}
