using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 27 de julio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCreditosBancariosActionEnum
        {            public enum EnumtesCreditosBancariosAction
            {
                TotalHaber
            }
        public static string GetAcciontesCreditosBancariosAction(tesCreditosBancariosActionEnum.EnumtesCreditosBancariosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCreditosBancariosActionEnum.EnumtesCreditosBancariosAction.TotalHaber: lRetorno = "tesCreditosBancariosTotalHaber"; break;
            }
            return lRetorno;
        }
    }
}
