using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 18 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesRengMoviDebeActionEnum
        {            public enum EnumtesRengMoviDebeAction
            {
                Calcular
            }
        public static string GetAcciontesRengMoviDebeAction(tesRengMoviDebeActionEnum.EnumtesRengMoviDebeAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesRengMoviDebeActionEnum.EnumtesRengMoviDebeAction.Calcular: lRetorno = "tesRengMoviDebeCalcular"; break;
            }
            return lRetorno;
        }
    }
}
