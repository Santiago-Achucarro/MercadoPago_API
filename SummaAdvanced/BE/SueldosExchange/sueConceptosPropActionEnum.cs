using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 2 de junio de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueConceptosPropActionEnum
        {            public enum EnumsueConceptosPropAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionsueConceptosPropAction(sueConceptosPropActionEnum.EnumsueConceptosPropAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueConceptosPropActionEnum.EnumsueConceptosPropAction.Guardar: lRetorno = "sueConceptosPropGuardar"; break;
                case sueConceptosPropActionEnum.EnumsueConceptosPropAction.Eliminar: lRetorno = "sueConceptosPropEliminar"; break;
            }
            return lRetorno;
        }
    }
}
