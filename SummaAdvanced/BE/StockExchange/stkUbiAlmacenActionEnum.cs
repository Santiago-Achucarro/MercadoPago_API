using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 12 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkUbiAlmacenActionEnum
    {
        public enum EnumstkUbiAlmacenAction
        {
            Guardar, Datos, Pegar
        }
        public static string GetAccionstkUbiAlmacenAction(stkUbiAlmacenActionEnum.EnumstkUbiAlmacenAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkUbiAlmacenActionEnum.EnumstkUbiAlmacenAction.Guardar: lRetorno = "stkUbiAlmacenGuardar"; break;
                case stkUbiAlmacenActionEnum.EnumstkUbiAlmacenAction.Datos: lRetorno = "stkUbiAlmacenDevolverDatos"; break;
                case stkUbiAlmacenActionEnum.EnumstkUbiAlmacenAction.Pegar: lRetorno = "stkUbiAlmacenPegar"; break;

            }
            return lRetorno;
        }
    }
}
