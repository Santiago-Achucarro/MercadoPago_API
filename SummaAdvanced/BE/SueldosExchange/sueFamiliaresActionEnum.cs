using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 2 de marzo de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueFamiliaresActionEnum
        {            public enum EnumsueFamiliaresAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionsueFamiliaresAction(sueFamiliaresActionEnum.EnumsueFamiliaresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueFamiliaresActionEnum.EnumsueFamiliaresAction.Guardar: lRetorno = "sueFamiliaresGuardar"; break;
                case sueFamiliaresActionEnum.EnumsueFamiliaresAction.Eliminar: lRetorno = "sueFamiliaresEliminar"; break;
            }
            return lRetorno;
        }
    }
}
