using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 6 de marzo de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comOCArticuloActionEnum
        {            public enum EnumcomOCArticuloAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomOCArticuloAction(comOCArticuloActionEnum.EnumcomOCArticuloAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOCArticuloActionEnum.EnumcomOCArticuloAction.Guardar: lRetorno = "comOCArticuloGuardar"; break;
                case comOCArticuloActionEnum.EnumcomOCArticuloAction.Datos: lRetorno = "comOCArticuloDevolverDatos"; break;
                case comOCArticuloActionEnum.EnumcomOCArticuloAction.Eliminar: lRetorno = "comOCArticuloEliminar"; break;
            }
            return lRetorno;
        }
    }
}
