using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 15 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkMoviCabeDatosSalidasRemitoActionEnum
        {            public enum EnumstkMoviCabeDatosSalidasRemitoAction
            {
                Guardar,Datos,Eliminar,Imprimir
            }
        public static string GetAccionstkMoviCabeDatosSalidasRemitoAction(stkMoviCabeDatosSalidasRemitoActionEnum.EnumstkMoviCabeDatosSalidasRemitoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkMoviCabeDatosSalidasRemitoActionEnum.EnumstkMoviCabeDatosSalidasRemitoAction.Guardar: lRetorno = "stkMoviCabeDatosSalidasRemitoGuardar"; break;
                case stkMoviCabeDatosSalidasRemitoActionEnum.EnumstkMoviCabeDatosSalidasRemitoAction.Datos: lRetorno = "stkMoviCabeDatosSalidasRemitoDevolverDatos"; break;
                case stkMoviCabeDatosSalidasRemitoActionEnum.EnumstkMoviCabeDatosSalidasRemitoAction.Eliminar: lRetorno = "stkMoviCabeDatosSalidasRemitoEliminar"; break;
                case stkMoviCabeDatosSalidasRemitoActionEnum.EnumstkMoviCabeDatosSalidasRemitoAction.Imprimir: lRetorno = "stkMoviCabeDatosSalidasRemitoImprimir"; break;
            }
            return lRetorno;
        }
    }
}
