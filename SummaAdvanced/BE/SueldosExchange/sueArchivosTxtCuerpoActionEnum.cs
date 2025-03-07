using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 16 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueArchivosTxtCuerpoActionEnum
        {            public enum EnumsueArchivosTxtCuerpoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueArchivosTxtCuerpoAction(sueArchivosTxtCuerpoActionEnum.EnumsueArchivosTxtCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueArchivosTxtCuerpoActionEnum.EnumsueArchivosTxtCuerpoAction.Guardar: lRetorno = "sueArchivosTxtCuerpoGuardar"; break;
                case sueArchivosTxtCuerpoActionEnum.EnumsueArchivosTxtCuerpoAction.Datos: lRetorno = "sueArchivosTxtCuerpoDevolverDatos"; break;
                case sueArchivosTxtCuerpoActionEnum.EnumsueArchivosTxtCuerpoAction.Eliminar: lRetorno = "sueArchivosTxtCuerpoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
