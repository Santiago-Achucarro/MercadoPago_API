using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 23 de noviembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comProveedoresRetencionActionEnum
        {            public enum EnumcomProveedoresRetencionAction
            {
                Guardar,Eliminar
            }
        public static string GetAccioncomProveedoresRetencionAction(comProveedoresRetencionActionEnum.EnumcomProveedoresRetencionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comProveedoresRetencionActionEnum.EnumcomProveedoresRetencionAction.Guardar: lRetorno = "comProveedoresRetencionGuardar"; break;
                case comProveedoresRetencionActionEnum.EnumcomProveedoresRetencionAction.Eliminar: lRetorno = "comProveedoresRetencionEliminar"; break;
            }
            return lRetorno;
        }
    }
}
