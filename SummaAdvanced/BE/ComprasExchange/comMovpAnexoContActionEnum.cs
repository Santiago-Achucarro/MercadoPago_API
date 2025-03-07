using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de septiembre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovpAnexoContActionEnum
        {            public enum EnumcomMovpAnexoContAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomMovpAnexoContAction(comMovpAnexoContActionEnum.EnumcomMovpAnexoContAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovpAnexoContActionEnum.EnumcomMovpAnexoContAction.Guardar: lRetorno = "comMovpAnexoContGuardar"; break;
                case comMovpAnexoContActionEnum.EnumcomMovpAnexoContAction.Datos: lRetorno = "comMovpAnexoContDevolverDatos"; break;
                case comMovpAnexoContActionEnum.EnumcomMovpAnexoContAction.Eliminar: lRetorno = "comMovpAnexoContEliminar"; break;
            }
            return lRetorno;
        }
    }
}
