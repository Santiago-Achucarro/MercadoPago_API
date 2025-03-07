using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, September 2, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueDatoXConceptoActionEnum
        {            public enum EnumsueDatoXConceptoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueDatoXConceptoAction(sueDatoXConceptoActionEnum.EnumsueDatoXConceptoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueDatoXConceptoActionEnum.EnumsueDatoXConceptoAction.Guardar: lRetorno = "sueDatoXConceptoGuardar"; break;
                case sueDatoXConceptoActionEnum.EnumsueDatoXConceptoAction.Datos: lRetorno = "sueDatoXConceptoDevolverDatos"; break;
                case sueDatoXConceptoActionEnum.EnumsueDatoXConceptoAction.Eliminar: lRetorno = "sueDatoXConceptoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
