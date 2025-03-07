using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 27 de agosto de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class espstkTalleKSKActionEnum
        {            public enum EnumespstkTalleKSKAction
        {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespstkTalleKSKAction(espstkTalleKSKActionEnum.EnumespstkTalleKSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espstkTalleKSKActionEnum.EnumespstkTalleKSKAction.Guardar: lRetorno = "espstkTalleKSKGuardar"; break;
                case espstkTalleKSKActionEnum.EnumespstkTalleKSKAction.Datos: lRetorno = "espstkTalleKSKDevolverDatos"; break;
                case espstkTalleKSKActionEnum.EnumespstkTalleKSKAction.Eliminar: lRetorno = "espstkTalleKSKEliminar"; break;
            }
            return lRetorno;
        }
    }
}
