using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 10 de abril de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comProveedoresDatosCUITActionEnum
        {            public enum EnumcomProveedoresDatosCUITAction
            {
                Datos
            }
        public static string GetAccioncomProveedoresDatosCUITAction(comProveedoresDatosCUITActionEnum.EnumcomProveedoresDatosCUITAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comProveedoresDatosCUITActionEnum.EnumcomProveedoresDatosCUITAction.Datos: lRetorno = "comProveedoresDatosCUITDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
