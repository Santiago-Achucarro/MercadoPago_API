using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 20 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvDatosPorDifPrecioActionEnum
        {            public enum EnumcomMovProvDatosPorDifPrecioAction
            {
                Guardar,Datos,Eliminar,CalcularTotales,CalcularTotalImp,SubirXML,AsignarFecha,CalcularImpuesto,DatosProv
        }
        public static string GetAccioncomMovProvDatosPorDifPrecioAction(comMovProvDatosPorDifPrecioActionEnum.EnumcomMovProvDatosPorDifPrecioAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvDatosPorDifPrecioActionEnum.EnumcomMovProvDatosPorDifPrecioAction.Guardar: lRetorno = "comMovProvDatosPorDifPrecioGuardar"; break;
                case comMovProvDatosPorDifPrecioActionEnum.EnumcomMovProvDatosPorDifPrecioAction.Datos: lRetorno = "comMovProvDatosPorDifPrecioDevolverDatos"; break;
                case comMovProvDatosPorDifPrecioActionEnum.EnumcomMovProvDatosPorDifPrecioAction.Eliminar: lRetorno = "comMovProvDatosPorDifPrecioEliminar"; break;
                case comMovProvDatosPorDifPrecioActionEnum.EnumcomMovProvDatosPorDifPrecioAction.CalcularTotales: lRetorno = "comMovProvDatosPorDifPrecioCalcularTotales"; break;
                case comMovProvDatosPorDifPrecioActionEnum.EnumcomMovProvDatosPorDifPrecioAction.CalcularTotalImp: lRetorno = "comMovProvDatosPorDifPrecioCalcularTotalImp"; break;
                case comMovProvDatosPorDifPrecioActionEnum.EnumcomMovProvDatosPorDifPrecioAction.SubirXML: lRetorno = "comMovProvDatosPorDifPrecioSubirXML"; break;
                case comMovProvDatosPorDifPrecioActionEnum.EnumcomMovProvDatosPorDifPrecioAction.AsignarFecha: lRetorno = "comMovProvDatosPorDifPrecioAsignarFecha"; break;
                case comMovProvDatosPorDifPrecioActionEnum.EnumcomMovProvDatosPorDifPrecioAction.CalcularImpuesto:lRetorno = "comMovProvDatosPorDifPrecioCalcularImpuesto"; break;
                case comMovProvDatosPorDifPrecioActionEnum.EnumcomMovProvDatosPorDifPrecioAction.DatosProv:lRetorno = "comMovProvDatosPorDifPrecioDatosProv"; break;

            }
            return lRetorno;
        }
    }
}
