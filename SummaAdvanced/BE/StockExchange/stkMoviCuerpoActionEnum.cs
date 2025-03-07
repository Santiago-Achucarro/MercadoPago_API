using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 7 de julio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviCuerpoActionEnum
        {            public enum EnumstkMoviCuerpoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkMoviCuerpoAction(stkMoviCuerpoActionEnum.EnumstkMoviCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCuerpoActionEnum.EnumstkMoviCuerpoAction.Guardar: lRetorno = "stkMoviCuerpoGuardar"; break;
                case stkMoviCuerpoActionEnum.EnumstkMoviCuerpoAction.Datos: lRetorno = "stkMoviCuerpoDevolverDatos"; break;
                case stkMoviCuerpoActionEnum.EnumstkMoviCuerpoAction.Eliminar: lRetorno = "stkMoviCuerpoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
