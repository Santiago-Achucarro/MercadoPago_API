using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de septiembre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovpAnexoActionEnum
        {            public enum EnumcomMovpAnexoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomMovpAnexoAction(comMovpAnexoActionEnum.EnumcomMovpAnexoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovpAnexoActionEnum.EnumcomMovpAnexoAction.Guardar: lRetorno = "comMovpAnexoGuardar"; break;
                case comMovpAnexoActionEnum.EnumcomMovpAnexoAction.Datos: lRetorno = "comMovpAnexoDevolverDatos"; break;
                case comMovpAnexoActionEnum.EnumcomMovpAnexoAction.Eliminar: lRetorno = "comMovpAnexoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
