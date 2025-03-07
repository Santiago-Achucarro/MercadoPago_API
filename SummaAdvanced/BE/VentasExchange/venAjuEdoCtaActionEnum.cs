using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 15 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venAjuEdoCtaActionEnum
        {            public enum EnumvenAjuEdoCtaAction
            {
                Guardar,Datos
            }
        public static string GetAccionvenAjuEdoCtaAction(venAjuEdoCtaActionEnum.EnumvenAjuEdoCtaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venAjuEdoCtaActionEnum.EnumvenAjuEdoCtaAction.Guardar: lRetorno = "venAjuEdoCtaGuardar"; break;
                case venAjuEdoCtaActionEnum.EnumvenAjuEdoCtaAction.Datos: lRetorno = "venAjuEdoCtaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
