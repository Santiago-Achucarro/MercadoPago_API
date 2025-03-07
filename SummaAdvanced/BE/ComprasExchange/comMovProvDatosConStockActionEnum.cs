using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 16 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comMovProvDatosConStockActionEnum
    {
        public enum EnumcomMovProvDatosConStockAction
        {
            Guardar, Datos, Eliminar, CalcularTotales, CalcularTotalImp, SubirXML, AsignarFecha, CalcularImpuesto, DatosProv, AsignarCambio, Adjuntos
        }
        public static string GetAccioncomMovProvDatosConStockAction(comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction.Guardar: lRetorno = "comMovProvDatosConStockGuardar"; break;
                case comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction.Datos: lRetorno = "comMovProvDatosConStockDevolverDatos"; break;
                case comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction.Eliminar: lRetorno = "comMovProvDatosConStockEliminar"; break;
                case comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction.CalcularTotales: lRetorno = "comMovProvDatosConStockCalcularTotales"; break;
                case comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction.CalcularTotalImp: lRetorno = "comMovProvDatosConStockCalcularTotalImp"; break;
                case comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction.SubirXML: lRetorno = "comMovProvDatosConStockSubirXML"; break;
                case comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction.AsignarFecha: lRetorno = "comMovProvDatosConStockAsignarFecha"; break;
                case comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction.CalcularImpuesto: lRetorno = "comMovProvDatosConStockCalcularImpuesto"; break;
                case comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction.DatosProv: lRetorno = "comMovProvDatosConStockDatosProv"; break;
                case comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction.AsignarCambio: lRetorno = "comMovProvDatosConStockAsignarCambio"; break;
                case comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction.Adjuntos: lRetorno = "comMovProvDatosConStockAdjuntos"; break;
            }
            return lRetorno;
        }
    }
}
