using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 15 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conTiposSATActionEnum
        {            public enum EnumconTiposSATAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconTiposSATAction(conTiposSATActionEnum.EnumconTiposSATAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conTiposSATActionEnum.EnumconTiposSATAction.Guardar: lRetorno = "conTiposSATGuardar"; break;
                case conTiposSATActionEnum.EnumconTiposSATAction.Datos: lRetorno = "conTiposSATDevolverDatos"; break;
                case conTiposSATActionEnum.EnumconTiposSATAction.Eliminar: lRetorno = "conTiposSATEliminar"; break;
            }
            return lRetorno;
        }
    }
}
