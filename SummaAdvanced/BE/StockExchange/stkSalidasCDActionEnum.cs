using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 15 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkSalidasCDActionEnum
    {
        public enum EnumstkSalidasCDAction
        {
            Guardar, Datos, Eliminar, Entrada, TraeSolicitud, Descargar
        }
        public static string GetAccionstkSalidasCDAction(stkSalidasCDActionEnum.EnumstkSalidasCDAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkSalidasCDActionEnum.EnumstkSalidasCDAction.Guardar: lRetorno = "stkSalidasCDGuardar"; break;
                case stkSalidasCDActionEnum.EnumstkSalidasCDAction.Datos: lRetorno = "stkSalidasCDDevolverDatos"; break;
                case stkSalidasCDActionEnum.EnumstkSalidasCDAction.Eliminar: lRetorno = "stkSalidasCDEliminar"; break;
                case stkSalidasCDActionEnum.EnumstkSalidasCDAction.Entrada: lRetorno = "stkSalidasCDEntrada"; break;
                case stkSalidasCDActionEnum.EnumstkSalidasCDAction.TraeSolicitud: lRetorno = "stkSalidasCDTraeSolicitud"; break;
                case stkSalidasCDActionEnum.EnumstkSalidasCDAction.Descargar: lRetorno = "stkSalidasCDDescargar"; break;
            }
            return lRetorno;
        }
    }
}
