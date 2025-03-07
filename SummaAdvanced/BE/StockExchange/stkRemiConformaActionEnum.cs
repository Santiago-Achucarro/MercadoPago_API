using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 3 de agosto de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkRemiConformaActionEnum
        {            public enum EnumstkRemiConformaAction
            {
                Guardar,Datos,Eliminar, Adjuntos
        }
        public static string GetAccionstkRemiConformaAction(stkRemiConformaActionEnum.EnumstkRemiConformaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkRemiConformaActionEnum.EnumstkRemiConformaAction.Guardar: lRetorno = "stkRemiConformaGuardar"; break;
                case stkRemiConformaActionEnum.EnumstkRemiConformaAction.Datos: lRetorno = "stkRemiConformaDevolverDatos"; break;
                case stkRemiConformaActionEnum.EnumstkRemiConformaAction.Eliminar: lRetorno = "stkRemiConformaEliminar"; break;
                case stkRemiConformaActionEnum.EnumstkRemiConformaAction.Adjuntos: lRetorno = "stkRemiConformaAdjuntos"; break;
            }
            return lRetorno;
        }
    }
}
