using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 29 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proCierresCostoActionEnum
        {            public enum EnumproCierresCostoAction
            {
                Datos
            }
        public static string GetAccionproCierresCostoAction(proCierresCostoActionEnum.EnumproCierresCostoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proCierresCostoActionEnum.EnumproCierresCostoAction.Datos: lRetorno = "proCierresCostoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
