using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 14 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conRubroPreviActionEnum
        {            public enum EnumconRubroPreviAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconRubroPreviAction(conRubroPreviActionEnum.EnumconRubroPreviAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conRubroPreviActionEnum.EnumconRubroPreviAction.Guardar: lRetorno = "conRubroPreviGuardar"; break;
                case conRubroPreviActionEnum.EnumconRubroPreviAction.Datos: lRetorno = "conRubroPreviDevolverDatos"; break;
                case conRubroPreviActionEnum.EnumconRubroPreviAction.Eliminar: lRetorno = "conRubroPreviEliminar"; break;
            }
            return lRetorno;
        }
    }
}
