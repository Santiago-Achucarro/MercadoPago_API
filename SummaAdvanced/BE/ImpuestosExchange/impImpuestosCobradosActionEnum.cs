using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 23 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impImpuestosCobradosActionEnum
        {            public enum EnumimpImpuestosCobradosAction
            {
                Datos
            }
        public static string GetAccionimpImpuestosCobradosAction(impImpuestosCobradosActionEnum.EnumimpImpuestosCobradosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impImpuestosCobradosActionEnum.EnumimpImpuestosCobradosAction.Datos: lRetorno = "impImpuestosCobradosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
