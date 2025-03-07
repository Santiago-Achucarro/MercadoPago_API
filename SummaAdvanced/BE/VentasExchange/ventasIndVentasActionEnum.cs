using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 9 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class ventasIndVentasActionEnum
        {            public enum EnumventasIndVentasAction
            {
                Datos
            }
        public static string GetAccionventasIndVentasAction(ventasIndVentasActionEnum.EnumventasIndVentasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case ventasIndVentasActionEnum.EnumventasIndVentasAction.Datos: lRetorno = "ventasIndVentasDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
