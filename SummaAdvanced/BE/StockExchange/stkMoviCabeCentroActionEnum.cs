using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 3 de julio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviCabeCentroActionEnum
        {            public enum EnumstkMoviCabeCentroAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkMoviCabeCentroAction(stkMoviCabeCentroActionEnum.EnumstkMoviCabeCentroAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCabeCentroActionEnum.EnumstkMoviCabeCentroAction.Guardar: lRetorno = "stkMoviCabeCentroGuardar"; break;
                case stkMoviCabeCentroActionEnum.EnumstkMoviCabeCentroAction.Datos: lRetorno = "stkMoviCabeCentroDevolverDatos"; break;
                case stkMoviCabeCentroActionEnum.EnumstkMoviCabeCentroAction.Eliminar: lRetorno = "stkMoviCabeCentroEliminar"; break;
            }
            return lRetorno;
        }
    }
}
