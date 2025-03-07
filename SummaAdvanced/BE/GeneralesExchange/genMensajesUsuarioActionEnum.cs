using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 11 de enero de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genMensajesUsuarioActionEnum
        {            public enum EnumgenMensajesUsuarioAction
            {
                Datos,Guardar,Borrar
            }
        public static string GetAcciongenMensajesUsuarioAction(genMensajesUsuarioActionEnum.EnumgenMensajesUsuarioAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genMensajesUsuarioActionEnum.EnumgenMensajesUsuarioAction.Datos: lRetorno = "genMensajesUsuarioDevolverDatos"; break;
                case genMensajesUsuarioActionEnum.EnumgenMensajesUsuarioAction.Guardar: lRetorno = "genMensajesUsuarioGuardar"; break;
                case genMensajesUsuarioActionEnum.EnumgenMensajesUsuarioAction.Borrar: lRetorno = "genMensajesUsuarioEliminar"; break;
            }
            return lRetorno;
        }
    }
}
