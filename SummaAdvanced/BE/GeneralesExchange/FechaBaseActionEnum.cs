using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 30 de junio de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class FechaBaseActionEnum
        {            public enum EnumFechaBaseAction
            {
                Datos
            }
        public static string GetAccionFechaBaseAction(FechaBaseActionEnum.EnumFechaBaseAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case FechaBaseActionEnum.EnumFechaBaseAction.Datos: lRetorno = "FechaBaseDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
