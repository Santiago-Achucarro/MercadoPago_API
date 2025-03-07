using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 3 de octubre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venGraVentasActionEnum
        {            public enum EnumvenGraVentasAction
            {
                Datos
            }
        public static string GetAccionvenGraVentasAction(venGraVentasActionEnum.EnumvenGraVentasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venGraVentasActionEnum.EnumvenGraVentasAction.Datos: lRetorno = "venGraVentasDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
