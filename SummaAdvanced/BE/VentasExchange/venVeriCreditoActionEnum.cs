using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 18 de abril de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange
{
    public static class venVeriCreditoActionEnum
    {
        public enum EnumvenVeriCreditoAction
        {
            Calcular
        }
        public static string GetAccionvenVeriCreditoAction(venVeriCreditoActionEnum.EnumvenVeriCreditoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case EnumvenVeriCreditoAction.Calcular: lRetorno = "venVeriCreditoCalcular"; break;
            }
            return lRetorno;
        }
    }
}
