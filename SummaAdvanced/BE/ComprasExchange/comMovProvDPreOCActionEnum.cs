using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 23 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvDPreOCActionEnum
        {            public enum EnumcomMovProvDPreOCAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomMovProvDPreOCAction(comMovProvDPreOCActionEnum.EnumcomMovProvDPreOCAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvDPreOCActionEnum.EnumcomMovProvDPreOCAction.Guardar: lRetorno = "comMovProvDPreOCGuardar"; break;
                case comMovProvDPreOCActionEnum.EnumcomMovProvDPreOCAction.Datos: lRetorno = "comMovProvDPreOCDevolverDatos"; break;
                case comMovProvDPreOCActionEnum.EnumcomMovProvDPreOCAction.Eliminar: lRetorno = "comMovProvDPreOCEliminar"; break;
            }
            return lRetorno;
        }
    }
}
