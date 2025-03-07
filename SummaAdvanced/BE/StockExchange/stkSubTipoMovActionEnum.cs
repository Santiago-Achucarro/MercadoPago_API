using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 13 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkSubTipoMovActionEnum
        {            public enum EnumstkSubTipoMovAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkSubTipoMovAction(stkSubTipoMovActionEnum.EnumstkSubTipoMovAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkSubTipoMovActionEnum.EnumstkSubTipoMovAction.Guardar: lRetorno = "stkSubTipoMovGuardar"; break;
                case stkSubTipoMovActionEnum.EnumstkSubTipoMovAction.Datos: lRetorno = "stkSubTipoMovDevolverDatos"; break;
                case stkSubTipoMovActionEnum.EnumstkSubTipoMovAction.Eliminar: lRetorno = "stkSubTipoMovEliminar"; break;
            }
            return lRetorno;
        }
    }
}
