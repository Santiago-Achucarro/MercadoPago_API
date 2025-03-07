using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 4 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesPagosClieTotalDebeActionEnum
        {            public enum EnumtesPagosClieTotalDebeAction
            {
                DatosPendientes
            }
        public static string GetAcciontesPagosClieTotalDebeAction(tesPagosClieTotalDebeActionEnum.EnumtesPagosClieTotalDebeAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesPagosClieTotalDebeActionEnum.EnumtesPagosClieTotalDebeAction.DatosPendientes: lRetorno = "tesPagosClieDatosPendientes"; break;
            }
            return lRetorno;
        }
    }
}
