using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 1 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comAjuEdoCtaActionEnum
        {            public enum EnumcomAjuEdoCtaAction
            {
                Guardar,Datos
            }
        public static string GetAccioncomAjuEdoCtaAction(comAjuEdoCtaActionEnum.EnumcomAjuEdoCtaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comAjuEdoCtaActionEnum.EnumcomAjuEdoCtaAction.Guardar: lRetorno = "comAjuEdoCtaGuardar"; break;
                case comAjuEdoCtaActionEnum.EnumcomAjuEdoCtaAction.Datos: lRetorno = "comAjuEdoCtaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
