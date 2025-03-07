using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, October 20, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genUsuariosRecuperarActionEnum
        {            public enum EnumgenUsuariosRecuperarAction
            {
                Guardar,Datos
            }
        public static string GetAcciongenUsuariosRecuperarAction(genUsuariosRecuperarActionEnum.EnumgenUsuariosRecuperarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genUsuariosRecuperarActionEnum.EnumgenUsuariosRecuperarAction.Guardar: lRetorno = "genUsuariosRecuperarGuardar"; break;
                case genUsuariosRecuperarActionEnum.EnumgenUsuariosRecuperarAction.Datos: lRetorno = "genUsuariosRecuperarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
