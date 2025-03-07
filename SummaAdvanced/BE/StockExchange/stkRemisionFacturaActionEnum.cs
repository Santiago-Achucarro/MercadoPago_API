using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 13 de febrero de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkRemisionFacturaActionEnum
        {            public enum EnumstkRemisionFacturaAction
            {
                Guardar,Datos,Eliminar,Todos
            }
        public static string GetAccionstkRemisionFacturaAction(stkRemisionFacturaActionEnum.EnumstkRemisionFacturaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkRemisionFacturaActionEnum.EnumstkRemisionFacturaAction.Guardar: lRetorno = "stkRemisionFacturaGuardar"; break;
                case stkRemisionFacturaActionEnum.EnumstkRemisionFacturaAction.Datos: lRetorno = "stkRemisionFacturaDevolverDatos"; break;
                case stkRemisionFacturaActionEnum.EnumstkRemisionFacturaAction.Eliminar: lRetorno = "stkRemisionFacturaEliminar"; break;
                case stkRemisionFacturaActionEnum.EnumstkRemisionFacturaAction.Todos: lRetorno = "stkRemisionFacturaTodos"; break;
            }
            return lRetorno;
        }
    }
}
