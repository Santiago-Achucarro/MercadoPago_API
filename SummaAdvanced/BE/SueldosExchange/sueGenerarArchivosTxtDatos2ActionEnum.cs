using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 11 de octubre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueGenerarArchivosTxtDatos2ActionEnum
        {            public enum EnumsueGenerarArchivosTxtDatos2Action
            {
                Datos
            }
        public static string GetAccionsueGenerarArchivosTxtDatos2Action(sueGenerarArchivosTxtDatos2ActionEnum.EnumsueGenerarArchivosTxtDatos2Action pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueGenerarArchivosTxtDatos2ActionEnum.EnumsueGenerarArchivosTxtDatos2Action.Datos: lRetorno = "sueGenerarArchivosTxtDatos2DevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
