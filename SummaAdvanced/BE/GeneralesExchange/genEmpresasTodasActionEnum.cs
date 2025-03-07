using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 4 de octubre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genEmpresasTodasActionEnum
        {            public enum EnumgenEmpresasTodasAction
            {
                Datos
            }
        public static string GetAcciongenEmpresasTodasAction(genEmpresasTodasActionEnum.EnumgenEmpresasTodasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genEmpresasTodasActionEnum.EnumgenEmpresasTodasAction.Datos: lRetorno = "genEmpresasTodasDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
