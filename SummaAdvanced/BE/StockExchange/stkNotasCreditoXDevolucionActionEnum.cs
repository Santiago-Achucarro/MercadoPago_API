using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 14 de enero de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkNotasCreditoXDevolucionActionEnum
        {            public enum EnumstkNotasCreditoXDevolucionAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionstkNotasCreditoXDevolucionAction(stkNotasCreditoXDevolucionActionEnum.EnumstkNotasCreditoXDevolucionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkNotasCreditoXDevolucionActionEnum.EnumstkNotasCreditoXDevolucionAction.Guardar: lRetorno = "stkNotasCreditoXDevolucionGuardar"; break;
                case stkNotasCreditoXDevolucionActionEnum.EnumstkNotasCreditoXDevolucionAction.Datos: lRetorno = "stkNotasCreditoXDevolucionDevolverDatos"; break;
                case stkNotasCreditoXDevolucionActionEnum.EnumstkNotasCreditoXDevolucionAction.Eliminar: lRetorno = "stkNotasCreditoXDevolucionEliminar"; break;
            }
            return lRetorno;
        }
    }
}
