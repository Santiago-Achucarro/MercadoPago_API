using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 17 de abril de 2022
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvDevengaActionEnum
        {
        public enum EnumcomMovProvDevengaAction
        {
            Guardar, Datos, Eliminar, CalcularTotal, LeerXml, CalucularTotalImp, LlenarCuentas, AsignarFecha, CalcularImpuesto, Adjuntos
        }
        public static string GetAccioncomMovProvDevengaAction(comMovProvDevengaActionEnum.EnumcomMovProvDevengaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvDevengaActionEnum.EnumcomMovProvDevengaAction.Guardar: lRetorno = "comMovProvDevengaGuardar"; break;
                case comMovProvDevengaActionEnum.EnumcomMovProvDevengaAction.Datos: lRetorno = "comMovProvDevengaDevolverDatos"; break;
                case comMovProvDevengaActionEnum.EnumcomMovProvDevengaAction.Eliminar: lRetorno = "comMovProvDevengaEliminar"; break;
                case comMovProvDevengaActionEnum.EnumcomMovProvDevengaAction.CalcularTotal: lRetorno = "comMovProvDevengaCalcularTotal"; break;
                case comMovProvDevengaActionEnum.EnumcomMovProvDevengaAction.LeerXml: lRetorno = "comMovProvDevengaLeerXml"; break;
                case comMovProvDevengaActionEnum.EnumcomMovProvDevengaAction.CalucularTotalImp: lRetorno = "comMovProvDevengaCalucularTotalImp"; break;
                case comMovProvDevengaActionEnum.EnumcomMovProvDevengaAction.LlenarCuentas: lRetorno = "comMovProvDevengaLlenarCuentas"; break;
                case comMovProvDevengaActionEnum.EnumcomMovProvDevengaAction.AsignarFecha: lRetorno = "comMovProvDevengaAsignarFecha"; break;
                case comMovProvDevengaActionEnum.EnumcomMovProvDevengaAction.CalcularImpuesto: lRetorno = "comMovProvDevengaCalcularImpuesto"; break;
                case comMovProvDevengaActionEnum.EnumcomMovProvDevengaAction.Adjuntos: lRetorno = "comMovProvDevengaAdjuntos"; break;
            }
            return lRetorno;
        }
    }
}
