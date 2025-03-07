using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 28 de diciembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genCodPostalActionEnum
        {            public enum EnumgenCodPostalAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenCodPostalAction(genCodPostalActionEnum.EnumgenCodPostalAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genCodPostalActionEnum.EnumgenCodPostalAction.Guardar: lRetorno = "genCodPostalGuardar"; break;
                case genCodPostalActionEnum.EnumgenCodPostalAction.Datos: lRetorno = "genCodPostalDevolverDatos"; break;
                case genCodPostalActionEnum.EnumgenCodPostalAction.Eliminar: lRetorno = "genCodPostalEliminar"; break;
            }
            return lRetorno;
        }
    }
}
