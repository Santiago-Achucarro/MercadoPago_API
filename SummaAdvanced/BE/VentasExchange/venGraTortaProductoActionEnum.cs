using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 9 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venGraTortaProductoActionEnum
        {            public enum EnumvenGraTortaProductoAction
            {
                Datos
            }
        public static string GetAccionvenGraTortaProductoAction(venGraTortaProductoActionEnum.EnumvenGraTortaProductoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venGraTortaProductoActionEnum.EnumvenGraTortaProductoAction.Datos: lRetorno = "venGraTortaProductoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
