using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 22 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovPOCActionEnum
        {            public enum EnumcomMovPOCAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomMovPOCAction(comMovPOCActionEnum.EnumcomMovPOCAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovPOCActionEnum.EnumcomMovPOCAction.Guardar: lRetorno = "comMovPOCGuardar"; break;
                case comMovPOCActionEnum.EnumcomMovPOCAction.Datos: lRetorno = "comMovPOCDevolverDatos"; break;
                case comMovPOCActionEnum.EnumcomMovPOCAction.Eliminar: lRetorno = "comMovPOCEliminar"; break;
            }
            return lRetorno;
        }
    }
}
