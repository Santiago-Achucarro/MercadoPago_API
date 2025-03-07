using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 2 de marzo de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueLegajoFamiliaresActionEnum
        {            public enum EnumsueLegajoFamiliaresAction
            {
                Guardar,Datos
            }
        public static string GetAccionsueLegajoFamiliaresAction(sueLegajoFamiliaresActionEnum.EnumsueLegajoFamiliaresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueLegajoFamiliaresActionEnum.EnumsueLegajoFamiliaresAction.Guardar: lRetorno = "sueLegajoFamiliaresGuardar"; break;
                case sueLegajoFamiliaresActionEnum.EnumsueLegajoFamiliaresAction.Datos: lRetorno = "sueLegajoFamiliaresDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
