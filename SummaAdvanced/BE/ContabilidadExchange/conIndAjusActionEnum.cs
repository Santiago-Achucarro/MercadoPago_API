using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 14 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conIndAjusActionEnum
        {            public enum EnumconIndAjusAction
            {
                Guardar,Datos,Eliminar,DatosWS
            }
        public static string GetAccionconIndAjusAction(conIndAjusActionEnum.EnumconIndAjusAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conIndAjusActionEnum.EnumconIndAjusAction.Guardar: lRetorno = "conIndAjusGuardar"; break;
                case conIndAjusActionEnum.EnumconIndAjusAction.Datos: lRetorno = "conIndAjusDevolverDatos"; break;
                case conIndAjusActionEnum.EnumconIndAjusAction.Eliminar: lRetorno = "conIndAjusEliminar"; break;
                case conIndAjusActionEnum.EnumconIndAjusAction.DatosWS: lRetorno = "conIndAjusDatosWs"; break;
            }
            return lRetorno;
        }
    }
}
