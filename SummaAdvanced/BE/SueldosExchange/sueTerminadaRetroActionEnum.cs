using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 11 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueTerminadaRetroActionEnum
        {            public enum EnumsueTerminadaRetroAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueTerminadaRetroAction(sueTerminadaRetroActionEnum.EnumsueTerminadaRetroAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueTerminadaRetroActionEnum.EnumsueTerminadaRetroAction.Guardar: lRetorno = "sueTerminadaRetroGuardar"; break;
                case sueTerminadaRetroActionEnum.EnumsueTerminadaRetroAction.Datos: lRetorno = "sueTerminadaRetroDevolverDatos"; break;
                case sueTerminadaRetroActionEnum.EnumsueTerminadaRetroAction.Eliminar: lRetorno = "sueTerminadaRetroEliminar"; break;
            }
            return lRetorno;
        }
    }
}
