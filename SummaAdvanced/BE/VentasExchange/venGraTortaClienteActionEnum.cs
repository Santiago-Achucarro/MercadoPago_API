using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 9 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venGraTortaClienteActionEnum
        {            public enum EnumvenGraTortaClienteAction
            {
                Datos
            }
        public static string GetAccionvenGraTortaClienteAction(venGraTortaClienteActionEnum.EnumvenGraTortaClienteAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venGraTortaClienteActionEnum.EnumvenGraTortaClienteAction.Datos: lRetorno = "venGraTortaClienteDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
