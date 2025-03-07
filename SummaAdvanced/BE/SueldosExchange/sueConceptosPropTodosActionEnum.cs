using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 2 de junio de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueConceptosPropTodosActionEnum
        {            public enum EnumsueConceptosPropTodosAction
            {
                Guardar, Datos
            }
        public static string GetAccionsueConceptosPropTodosAction(sueConceptosPropTodosActionEnum.EnumsueConceptosPropTodosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueConceptosPropTodosActionEnum.EnumsueConceptosPropTodosAction.Guardar: lRetorno = "sueConceptosPropTodosGuardar"; break;
                case sueConceptosPropTodosActionEnum.EnumsueConceptosPropTodosAction.Datos: lRetorno = "sueConceptosPropTodosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
