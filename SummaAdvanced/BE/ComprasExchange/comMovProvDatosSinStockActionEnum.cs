using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 27 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comMovProvDatosSinStockActionEnum
    {
        public enum EnumcomMovProvDatosSinStockAction
        {
            Guardar, Datos, Eliminar, CalcularTotal, LeerXml, CalucularTotalImp, LlenarCuentas, AsignarFecha, CalcularImpuesto, Adjuntos
        }
        public static string GetAccioncomMovProvDatosSinStockAction
            (comMovProvDatosSinStockActionEnum.EnumcomMovProvDatosSinStockAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvDatosSinStockActionEnum.EnumcomMovProvDatosSinStockAction.Guardar:
                    lRetorno = "comMovProvDatosSinStockGuardar";
                    break;
                case comMovProvDatosSinStockActionEnum.EnumcomMovProvDatosSinStockAction.Datos:
                    lRetorno = "comMovProvDatosSinStockDevolverDatos";
                    break;
                case comMovProvDatosSinStockActionEnum.EnumcomMovProvDatosSinStockAction.Eliminar:
                    lRetorno = "comMovProvDatosSinStockEliminar";
                    break;
                case comMovProvDatosSinStockActionEnum.EnumcomMovProvDatosSinStockAction.CalcularTotal:
                    lRetorno = "comMovProvDatosSinStockCalcularTotal";
                    break;
                case comMovProvDatosSinStockActionEnum.EnumcomMovProvDatosSinStockAction.LeerXml:
                    lRetorno = "comMovProvDatosSinStockLeerXml";
                    break;
                case comMovProvDatosSinStockActionEnum.EnumcomMovProvDatosSinStockAction.CalucularTotalImp:
                    lRetorno = "comMovProvDatosSinStockCalucularTotalImp";
                    break;
                case comMovProvDatosSinStockActionEnum.EnumcomMovProvDatosSinStockAction.LlenarCuentas:
                    lRetorno = "comMovProvDatosSinStockLlenarCuentas";
                    break;
                case comMovProvDatosSinStockActionEnum.EnumcomMovProvDatosSinStockAction.AsignarFecha:
                    lRetorno = "comMovProvDatosSinStockAsignarFecha";
                    break;
                case comMovProvDatosSinStockActionEnum.EnumcomMovProvDatosSinStockAction.CalcularImpuesto:
                    lRetorno = "comMovProvDatosSinStockCalcularImpuesto";
                    break;
                case comMovProvDatosSinStockActionEnum.EnumcomMovProvDatosSinStockAction.Adjuntos: lRetorno = "comMovProvDatosSinStockAdjuntos"; break;
            }
            return lRetorno;
        }
    }
}
