using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 19 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comOcReceCuerpoActionEnum
    {
        public enum EnumcomOcReceCuerpoAction
        {
            Guardar, Datos, Eliminar, ActuPendiente
        }
        public static string GetAccioncomOcReceCuerpoAction(comOcReceCuerpoActionEnum.EnumcomOcReceCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOcReceCuerpoActionEnum.EnumcomOcReceCuerpoAction.Guardar: lRetorno = "comOcReceCuerpoGuardar"; break;
                case comOcReceCuerpoActionEnum.EnumcomOcReceCuerpoAction.Datos: lRetorno = "comOcReceCuerpoDevolverDatos"; break;
                case comOcReceCuerpoActionEnum.EnumcomOcReceCuerpoAction.Eliminar: lRetorno = "comOcReceCuerpoEliminar"; break;
                case comOcReceCuerpoActionEnum.EnumcomOcReceCuerpoAction.ActuPendiente: lRetorno = "comOcReceCuerpoActuPendiente"; break;
            }
            return lRetorno;
        }
    }
}
