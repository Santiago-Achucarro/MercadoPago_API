using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 21 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impImpuestosPagadosAsiActionEnum
        {            public enum EnumimpImpuestosPagadosAsiAction
            {
                Datos
            }
        public static string GetAccionimpImpuestosPagadosAsiAction(impImpuestosPagadosAsiActionEnum.EnumimpImpuestosPagadosAsiAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impImpuestosPagadosAsiActionEnum.EnumimpImpuestosPagadosAsiAction.Datos: lRetorno = "impImpuestosPagadosAsiDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
