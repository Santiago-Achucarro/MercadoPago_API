using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 13 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkRemiCancPendActionEnum
        {            public enum EnumstkRemiCancPendAction
            {
                Guardar,Datos
            }
        public static string GetAccionstkRemiCancPendAction(stkRemiCancPendActionEnum.EnumstkRemiCancPendAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkRemiCancPendActionEnum.EnumstkRemiCancPendAction.Guardar: lRetorno = "stkRemiCancPendGuardar"; break;
                case stkRemiCancPendActionEnum.EnumstkRemiCancPendAction.Datos: lRetorno = "stkRemiCancPendDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
