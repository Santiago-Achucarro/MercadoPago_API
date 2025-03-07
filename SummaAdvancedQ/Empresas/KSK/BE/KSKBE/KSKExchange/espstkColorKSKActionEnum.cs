using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 26 de agosto de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange
{
        public static class espstkColorKSKActionEnum
        {            public enum EnumespstkColorKSKAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespstkColorKSKAction(espstkColorKSKActionEnum.EnumespstkColorKSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espstkColorKSKActionEnum.EnumespstkColorKSKAction.Guardar: lRetorno = "espstkColorKSKGuardar"; break;
                case espstkColorKSKActionEnum.EnumespstkColorKSKAction.Datos: lRetorno = "espstkColorKSKDevolverDatos"; break;
                case espstkColorKSKActionEnum.EnumespstkColorKSKAction.Eliminar: lRetorno = "espstkKSKKSKEliminar"; break;
            }
            return lRetorno;
        }
    }
}
