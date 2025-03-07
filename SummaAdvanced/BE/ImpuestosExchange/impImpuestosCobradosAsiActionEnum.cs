using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 23 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impImpuestosCobradosAsiActionEnum
        {            public enum EnumimpImpuestosCobradosAsiAction
            {
                Datos
            }
        public static string GetAccionimpImpuestosCobradosAsiAction(impImpuestosCobradosAsiActionEnum.EnumimpImpuestosCobradosAsiAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impImpuestosCobradosAsiActionEnum.EnumimpImpuestosCobradosAsiAction.Datos: lRetorno = "impImpuestosCobradosAsiDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
