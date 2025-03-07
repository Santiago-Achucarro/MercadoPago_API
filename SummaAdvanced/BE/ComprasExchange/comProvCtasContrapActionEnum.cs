using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 24 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comProvCtasContrapActionEnum
        {            public enum EnumcomProvCtasContrapAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomProvCtasContrapAction(comProvCtasContrapActionEnum.EnumcomProvCtasContrapAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comProvCtasContrapActionEnum.EnumcomProvCtasContrapAction.Guardar: lRetorno = "comProvCtasContrapGuardar"; break;
                case comProvCtasContrapActionEnum.EnumcomProvCtasContrapAction.Datos: lRetorno = "comProvCtasContrapDevolverDatos"; break;
                case comProvCtasContrapActionEnum.EnumcomProvCtasContrapAction.Eliminar: lRetorno = "comProvCtasContrapEliminar"; break;
            }
            return lRetorno;
        }
    }
}
