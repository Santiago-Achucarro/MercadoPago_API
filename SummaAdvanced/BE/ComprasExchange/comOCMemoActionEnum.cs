using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 6 de marzo de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comOCMemoActionEnum
        {            public enum EnumcomOCMemoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomOCMemoAction(comOCMemoActionEnum.EnumcomOCMemoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOCMemoActionEnum.EnumcomOCMemoAction.Guardar: lRetorno = "comOCMemoGuardar"; break;
                case comOCMemoActionEnum.EnumcomOCMemoAction.Datos: lRetorno = "comOCMemoDevolverDatos"; break;
                case comOCMemoActionEnum.EnumcomOCMemoAction.Eliminar: lRetorno = "comOCMemoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
