using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 13 de enero de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genAlertasUsuarioActionEnum
        {            public enum EnumgenAlertasUsuarioAction
            {
                Datos,Eliminar
            }
        public static string GetAcciongenAlertasUsuarioAction(genAlertasUsuarioActionEnum.EnumgenAlertasUsuarioAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genAlertasUsuarioActionEnum.EnumgenAlertasUsuarioAction.Datos: lRetorno = "genAlertasUsuarioDevolverDatos"; break;
                case genAlertasUsuarioActionEnum.EnumgenAlertasUsuarioAction.Eliminar: lRetorno = "genAlertasUsuarioEliminarMensajesUsuario"; break;
            }
            return lRetorno;
        }
    }
}
