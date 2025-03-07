using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 29 de junio de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class stkProductosActuCostoActionEnum
        {            public enum EnumstkProductosActuCostoAction
            {
                Guardar
            }
        public static string GetAccionstkProductosActuCostoAction(stkProductosActuCostoActionEnum.EnumstkProductosActuCostoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case stkProductosActuCostoActionEnum.EnumstkProductosActuCostoAction.Guardar: lRetorno = "stkProductosActuCostoGuardar"; break;
            }
            return lRetorno;
        }
    }
}
