using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 23 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueGenerarArchivosTxtActionEnum
        {            public enum EnumsueGenerarArchivosTxtAction
            {
                Datos,Generar
            }
        public static string GetAccionsueGenerarArchivosTxtAction(sueGenerarArchivosTxtActionEnum.EnumsueGenerarArchivosTxtAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueGenerarArchivosTxtActionEnum.EnumsueGenerarArchivosTxtAction.Datos: lRetorno = "sueGenerarArchivosTxtDevolverDatos"; break;
                case sueGenerarArchivosTxtActionEnum.EnumsueGenerarArchivosTxtAction.Generar: lRetorno = "sueGenerarArchivosTxtGenerar"; break;
            }
            return lRetorno;
        }
    }
}
