using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, September 1, 2023
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class venMovConStockActionEnum20241126
        {            public enum EnumvenMovConStockAction
            {
                Enviar
            }
        public static string GetAccionvenMovConStockAction(venMovConStockActionEnum20241126.EnumvenMovConStockAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovConStockActionEnum20241126.EnumvenMovConStockAction.Enviar: lRetorno = "venMovConStockEnviar"; break;
            }
            return lRetorno;
        }
    }
}
