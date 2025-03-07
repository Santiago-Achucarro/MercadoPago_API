using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 9 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venGraTortaVendedorActionEnum
        {            public enum EnumvenGraTortaVendedorAction
            {
                Datos
            }
        public static string GetAccionvenGraTortaVendedorAction(venGraTortaVendedorActionEnum.EnumvenGraTortaVendedorAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venGraTortaVendedorActionEnum.EnumvenGraTortaVendedorAction.Datos: lRetorno = "venGraTortaVendedorDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
