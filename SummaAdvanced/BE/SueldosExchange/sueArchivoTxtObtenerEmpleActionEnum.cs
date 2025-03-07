using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 11 de octubre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueArchivoTxtObtenerEmpleActionEnum
        {            public enum EnumsueArchivoTxtObtenerEmpleAction
            {
                Datos
            }
        public static string GetAccionsueArchivoTxtObtenerEmpleAction(sueArchivoTxtObtenerEmpleActionEnum.EnumsueArchivoTxtObtenerEmpleAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueArchivoTxtObtenerEmpleActionEnum.EnumsueArchivoTxtObtenerEmpleAction.Datos: lRetorno = "sueArchivoTxtObtenerEmpleDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
