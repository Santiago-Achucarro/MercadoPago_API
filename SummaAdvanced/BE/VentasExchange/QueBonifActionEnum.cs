using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 10 de junio de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class QueBonifActionEnum
        {            public enum EnumQueBonifAction
            {
                Datos
            }
        public static string GetAccionQueBonifAction(QueBonifActionEnum.EnumQueBonifAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case QueBonifActionEnum.EnumQueBonifAction.Datos: lRetorno = "QueBonifDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
