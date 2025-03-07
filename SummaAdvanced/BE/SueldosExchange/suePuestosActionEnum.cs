using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, June 28, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class suePuestosActionEnum
        {            public enum EnumsuePuestosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsuePuestosAction(suePuestosActionEnum.EnumsuePuestosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case suePuestosActionEnum.EnumsuePuestosAction.Guardar: lRetorno = "suePuestosGuardar"; break;
                case suePuestosActionEnum.EnumsuePuestosAction.Datos: lRetorno = "suePuestosDevolverDatos"; break;
                case suePuestosActionEnum.EnumsuePuestosAction.Eliminar: lRetorno = "suePuestosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
