using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 12 de agosto de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venListaPrecXLSActionEnum
        {            public enum EnumvenListaPrecXLSAction
            {
                Guardar
            }
        public static string GetAccionvenListaPrecXLSAction(venListaPrecXLSActionEnum.EnumvenListaPrecXLSAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venListaPrecXLSActionEnum.EnumvenListaPrecXLSAction.Guardar: lRetorno = "venListaPrecXLSGuardar"; break;
            }
            return lRetorno;
        }
    }
}
