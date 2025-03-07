using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 28 de mayo de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange
{
    public static class genUsuarioLoginActionEnum
    {
        public enum EnumgenUsuarioLoginAction
        {
            Login, ClaveValida
        }
        public static string GetAcciongenUsuarioLoginAction(genUsuarioLoginActionEnum.EnumgenUsuarioLoginAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genUsuarioLoginActionEnum.EnumgenUsuarioLoginAction.Login: lRetorno = "genUsuarioLogin"; break;
                case genUsuarioLoginActionEnum.EnumgenUsuarioLoginAction.ClaveValida: lRetorno = "genUsuarioLoginClaveValida"; break;
            }
            return lRetorno;
        }
    }
}
