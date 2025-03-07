using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 11 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueTerminadaActionEnum
        {            public enum EnumsueTerminadaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueTerminadaAction(sueTerminadaActionEnum.EnumsueTerminadaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueTerminadaActionEnum.EnumsueTerminadaAction.Guardar: lRetorno = "sueTerminadaGuardar"; break;
                case sueTerminadaActionEnum.EnumsueTerminadaAction.Datos: lRetorno = "sueTerminadaDevolverDatos"; break;
                case sueTerminadaActionEnum.EnumsueTerminadaAction.Eliminar: lRetorno = "sueTerminadaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
