using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 11 de mayo de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class venMovimientosConStockActionEnum
        {            public enum EnumvenMovimientosConStockAction
            {
                Guardar,Datos, ValoresDefecto, AsignaSaldoCobra, ConfInicial, LeerCodBarra
        }
        public static string GetAccionvenMovimientosConStockAction(venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.Guardar: lRetorno = "venMovimientosConStockGuardar"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.Datos: lRetorno = "venMovimientosConStockDevolverDatos"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.ValoresDefecto: lRetorno = "venMovimientosConStockValoresDefecto"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.AsignaSaldoCobra: lRetorno = "venMovimientosConStockAsignaSaldoCobra"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.ConfInicial: lRetorno = "venMovimientosConStockConfInicial"; break;
                case venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.LeerCodBarra: lRetorno = "venMovimientosConStockLeerCodBarra"; break;
            }
            return lRetorno;
        }
    }
}
