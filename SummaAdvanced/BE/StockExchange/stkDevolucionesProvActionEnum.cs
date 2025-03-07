using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 16 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkDevolucionesProvActionEnum
    {
        public enum EnumstkDevolucionesProvAction
        {
            Guardar, Datos, Eliminar, Todas
        }
        public static string GetAccionstkDevolucionesProvAction(stkDevolucionesProvActionEnum.EnumstkDevolucionesProvAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkDevolucionesProvActionEnum.EnumstkDevolucionesProvAction.Guardar: lRetorno = "stkDevolucionesProvGuardar"; break;
                case stkDevolucionesProvActionEnum.EnumstkDevolucionesProvAction.Datos: lRetorno = "stkDevolucionesProvDevolverDatos"; break;
                case stkDevolucionesProvActionEnum.EnumstkDevolucionesProvAction.Eliminar: lRetorno = "stkDevolucionesProvEliminar"; break;
                case stkDevolucionesProvActionEnum.EnumstkDevolucionesProvAction.Todas: lRetorno = "stkDevolucionesProvTodas"; break;
            }
            return lRetorno;
        }
    }
}
