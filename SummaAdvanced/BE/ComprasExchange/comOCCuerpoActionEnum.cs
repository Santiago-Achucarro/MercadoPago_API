using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 6 de marzo de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comOCCuerpoActionEnum
    {
        public enum EnumcomOCCuerpoAction
        {
            Guardar, Datos, Eliminar, Recibir, Facturar, Embarcar,Creditos, Consignar, ActuPendiente
        }
        public static string GetAccioncomOCCuerpoAction(comOCCuerpoActionEnum.EnumcomOCCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOCCuerpoActionEnum.EnumcomOCCuerpoAction.Guardar: lRetorno = "comOCCuerpoGuardar"; break;
                case comOCCuerpoActionEnum.EnumcomOCCuerpoAction.Datos: lRetorno = "comOCCuerpoDevolverDatos"; break;
                case comOCCuerpoActionEnum.EnumcomOCCuerpoAction.Eliminar: lRetorno = "comOCCuerpoEliminar"; break;
                case comOCCuerpoActionEnum.EnumcomOCCuerpoAction.Facturar: lRetorno = "comOCCuerpoFacturar"; break;
                case comOCCuerpoActionEnum.EnumcomOCCuerpoAction.Embarcar: lRetorno = "comOCCuerpoEmbarcar"; break;
                case comOCCuerpoActionEnum.EnumcomOCCuerpoAction.Recibir: lRetorno = "comOCCuerpoRecibir"; break;
                case comOCCuerpoActionEnum.EnumcomOCCuerpoAction.Creditos: lRetorno = "comOCCuerpoCreditos"; break;
                case comOCCuerpoActionEnum.EnumcomOCCuerpoAction.Consignar: lRetorno = "comOCCuerpoConsignar"; break;
                case comOCCuerpoActionEnum.EnumcomOCCuerpoAction.ActuPendiente: lRetorno = "comOCCuerpoActuPendiente"; break;
            }
            return lRetorno;
        }
    }
}
