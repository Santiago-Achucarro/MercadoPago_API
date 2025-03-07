using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 27 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvRemiPendActionEnum
        {            public enum EnumcomMovProvRemiPendAction
            {
                Guardar,Datos, Eliminar, CalcularTotales, CalcularTotalImp, SubirXML, AsignarFecha, CalcularImpuesto, DatosProv, AsignarMatRemitos, TipoCambio, 
                    Todas,Ninguna
        }
        public static string GetAccioncomMovProvRemiPendAction(comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction.Guardar: lRetorno = "comMovProvRemiPendGuardar"; break;
                case comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction.Datos: lRetorno = "comMovProvRemiPendDevolverDatos"; break;
                case comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction.Eliminar: lRetorno = "comMovProvRemiPendEliminar"; break;
                case comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction.CalcularTotales: lRetorno = "comMovProvRemiPendCalcularTotales"; break;
                case comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction.CalcularTotalImp: lRetorno = "comMovProvRemiPendCalcularTotalImp"; break;
                case comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction.SubirXML: lRetorno = "comMovProvRemiPendSubirXML"; break;
                case comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction.AsignarFecha: lRetorno = "comMovProvRemiPendAsignarFecha"; break;
                case comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction.CalcularImpuesto: lRetorno = "comMovProvRemiPendCalcularImpuesto"; break;
                case comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction.DatosProv: lRetorno = "comMovProvRemiPendDatosProv"; break;
                case comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction.AsignarMatRemitos:lRetorno = "comMovProvRemiPendAsignarMatRemitos"; break;
                case comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction.TipoCambio: lRetorno = "comMovProvRemiPendTipoCambio"; break;
                case comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction.Todas: lRetorno = "comMovProvRemiPendTodas"; break;
                case comMovProvRemiPendActionEnum.EnumcomMovProvRemiPendAction.Ninguna: lRetorno = "comMovProvRemiPendNinguna"; break;

            }
            return lRetorno;
        }
    }
}
