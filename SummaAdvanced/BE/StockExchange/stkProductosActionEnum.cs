using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 16 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>

namespace StockExchange
{
    public static class stkProductosActionEnum
    {
        public enum EnumstkProductosAction
        {
            Guardar, Datos, Eliminar, DatosActualizacion, CargarPlantilla, XLSGuardar, AdjuntosDatos
        }
        public static string GetAccionstkProductosAction(stkProductosActionEnum.EnumstkProductosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkProductosActionEnum.EnumstkProductosAction.Guardar: lRetorno = "stkProductosGuardar"; break;
                case stkProductosActionEnum.EnumstkProductosAction.Datos: lRetorno = "stkProductosDevolverDatos"; break;
                case stkProductosActionEnum.EnumstkProductosAction.Eliminar: lRetorno = "stkProductosEliminar"; break;
                case stkProductosActionEnum.EnumstkProductosAction.DatosActualizacion: lRetorno = "stkProductosDatosActualizacion"; break;
                case stkProductosActionEnum.EnumstkProductosAction.CargarPlantilla: lRetorno = "stkProductosCargarPlantilla"; break;
                case stkProductosActionEnum.EnumstkProductosAction.XLSGuardar: lRetorno = "stkProductosXLSGuardar"; break;
                case stkProductosActionEnum.EnumstkProductosAction.AdjuntosDatos: lRetorno = "stkProductosAdjuntosDatos"; break;
            }
            return lRetorno;
        }
    }
}
