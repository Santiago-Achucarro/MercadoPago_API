using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 4 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesPagosClieDatosBaseActionEnum
        {            public enum EnumtesPagosClieDatosBaseAction
            {
                DatosPendientes
            }
        public static string GetAcciontesPagosClieDatosBaseAction(tesPagosClieDatosBaseActionEnum.EnumtesPagosClieDatosBaseAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesPagosClieDatosBaseActionEnum.EnumtesPagosClieDatosBaseAction.DatosPendientes: lRetorno = "tesPagosClieDatosPendientes"; break;
            }
            return lRetorno;
        }
    }
}
