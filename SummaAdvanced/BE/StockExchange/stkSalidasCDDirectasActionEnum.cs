using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 16 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange
{
    public static class stkSalidasCDDirectasActionEnum
    {
        public enum EnumstkSalidasCDDirectasAction
        {
            Guardar, Datos, Eliminar, TraeSolicitud, OrdenProd
        }
        public static string GetAccionstkSalidasCDDirectasAction(stkSalidasCDDirectasActionEnum.EnumstkSalidasCDDirectasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkSalidasCDDirectasActionEnum.EnumstkSalidasCDDirectasAction.Guardar: lRetorno = "stkSalidasCDDirectasGuardar"; break;
                case stkSalidasCDDirectasActionEnum.EnumstkSalidasCDDirectasAction.Datos: lRetorno = "stkSalidasCDDirectasDevolverDatos"; break;
                case stkSalidasCDDirectasActionEnum.EnumstkSalidasCDDirectasAction.Eliminar: lRetorno = "stkSalidasCDDirectasEliminar"; break;
                case stkSalidasCDDirectasActionEnum.EnumstkSalidasCDDirectasAction.TraeSolicitud: lRetorno = "stkSalidasCDDirectasTraeSolicitud"; break;
                case stkSalidasCDDirectasActionEnum.EnumstkSalidasCDDirectasAction.OrdenProd: lRetorno = "stkSalidasCDDirectasOrdenProd"; break;
            }
            return lRetorno;
        }
    }
}
