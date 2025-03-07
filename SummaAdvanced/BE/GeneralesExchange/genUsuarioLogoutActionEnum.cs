using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 5 de abril de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
    public static class genUsuarioLogoutActionEnum
    {
        public enum EnumgenUsuarioLogoutAction
        {
            Logout                
        }

        public static string GetAcciongenUsuarioLogoutAction(genUsuarioLogoutActionEnum.EnumgenUsuarioLogoutAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genUsuarioLogoutActionEnum.EnumgenUsuarioLogoutAction.Logout: lRetorno = "genUsuarioLogout"; break;
            }
            return lRetorno;
        }
    }
}
