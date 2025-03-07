using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, September 1, 2023
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class venMovConStockActionEnum
        {            public enum EnumvenMovConStockAction
            {
                Enviar
            }
        public static string GetAccionvenMovConStockAction(venMovConStockActionEnum.EnumvenMovConStockAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovConStockActionEnum.EnumvenMovConStockAction.Enviar: lRetorno = "venMovConStockEnviar"; break;
            }
            return lRetorno;
        }
    }
}
