using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 12 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comDespachosActionEnum
        {            public enum EnumcomDespachosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomDespachosAction(comDespachosActionEnum.EnumcomDespachosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comDespachosActionEnum.EnumcomDespachosAction.Guardar: lRetorno = "comDespachosGuardar"; break;
                case comDespachosActionEnum.EnumcomDespachosAction.Datos: lRetorno = "comDespachosDevolverDatos"; break;
                case comDespachosActionEnum.EnumcomDespachosAction.Eliminar: lRetorno = "comDespachosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
