using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 21 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesFFCobranzaOtrosActionEnum
        {            public enum EnumtesFFCobranzaOtrosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesFFCobranzaOtrosAction(tesFFCobranzaOtrosActionEnum.EnumtesFFCobranzaOtrosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesFFCobranzaOtrosActionEnum.EnumtesFFCobranzaOtrosAction.Guardar: lRetorno = "tesFFCobranzaOtrosGuardar"; break;
                case tesFFCobranzaOtrosActionEnum.EnumtesFFCobranzaOtrosAction.Datos: lRetorno = "tesFFCobranzaOtrosDevolverDatos"; break;
                case tesFFCobranzaOtrosActionEnum.EnumtesFFCobranzaOtrosAction.Eliminar: lRetorno = "tesFFCobranzaOtrosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
