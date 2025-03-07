using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 11 de agosto de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace StockExchange{
        public static class QuePedimentoActionEnum
        {            public enum EnumQuePedimentoAction
            {
                Datos
            }
        public static string GetAccionQuePedimentoAction(QuePedimentoActionEnum.EnumQuePedimentoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case QuePedimentoActionEnum.EnumQuePedimentoAction.Datos: lRetorno = "QuePedimentoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
