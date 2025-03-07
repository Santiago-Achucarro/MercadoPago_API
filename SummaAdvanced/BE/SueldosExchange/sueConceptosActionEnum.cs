using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, July 19, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueConceptosActionEnum
        {            public enum EnumsueConceptosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueConceptosAction(sueConceptosActionEnum.EnumsueConceptosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueConceptosActionEnum.EnumsueConceptosAction.Guardar: lRetorno = "sueConceptosGuardar"; break;
                case sueConceptosActionEnum.EnumsueConceptosAction.Datos: lRetorno = "sueConceptosDevolverDatos"; break;
                case sueConceptosActionEnum.EnumsueConceptosAction.Eliminar: lRetorno = "sueConceptosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
