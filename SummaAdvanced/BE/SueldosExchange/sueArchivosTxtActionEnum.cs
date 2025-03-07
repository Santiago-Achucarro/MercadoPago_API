using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 16 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueArchivosTxtActionEnum
        {            public enum EnumsueArchivosTxtAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueArchivosTxtAction(sueArchivosTxtActionEnum.EnumsueArchivosTxtAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueArchivosTxtActionEnum.EnumsueArchivosTxtAction.Guardar: lRetorno = "sueArchivosTxtGuardar"; break;
                case sueArchivosTxtActionEnum.EnumsueArchivosTxtAction.Datos: lRetorno = "sueArchivosTxtDevolverDatos"; break;
                case sueArchivosTxtActionEnum.EnumsueArchivosTxtAction.Eliminar: lRetorno = "sueArchivosTxtEliminar"; break;
            }
            return lRetorno;
        }
    }
}
