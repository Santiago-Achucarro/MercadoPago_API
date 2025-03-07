using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 21 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impImpuestosPagadosActionEnum
        {            public enum EnumimpImpuestosPagadosAction
            {
                Datos
            }
        public static string GetAccionimpImpuestosPagadosAction(impImpuestosPagadosActionEnum.EnumimpImpuestosPagadosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impImpuestosPagadosActionEnum.EnumimpImpuestosPagadosAction.Datos: lRetorno = "impImpuestosPagadosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
