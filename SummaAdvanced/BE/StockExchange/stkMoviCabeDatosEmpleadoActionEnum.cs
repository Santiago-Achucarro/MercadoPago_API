using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 24 de septiembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviCabeDatosEmpleadoActionEnum
        {            public enum EnumstkMoviCabeDatosEmpleadoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkMoviCabeDatosEmpleadoAction(stkMoviCabeDatosEmpleadoActionEnum.EnumstkMoviCabeDatosEmpleadoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCabeDatosEmpleadoActionEnum.EnumstkMoviCabeDatosEmpleadoAction.Guardar: lRetorno = "stkMoviCabeDatosEmpleadoGuardar"; break;
                case stkMoviCabeDatosEmpleadoActionEnum.EnumstkMoviCabeDatosEmpleadoAction.Datos: lRetorno = "stkMoviCabeDatosEmpleadoDevolverDatos"; break;
                case stkMoviCabeDatosEmpleadoActionEnum.EnumstkMoviCabeDatosEmpleadoAction.Eliminar: lRetorno = "stkMoviCabeDatosEmpleadoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
