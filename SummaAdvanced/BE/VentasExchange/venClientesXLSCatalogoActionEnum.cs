using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 12 de agosto de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venClientesXLSCatalogoActionEnum
        {            public enum EnumvenClientesXLSCatalogoAction
            {
                Datos
            }
        public static string GetAccionvenClientesXLSCatalogoAction(venClientesXLSCatalogoActionEnum.EnumvenClientesXLSCatalogoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venClientesXLSCatalogoActionEnum.EnumvenClientesXLSCatalogoAction.Datos: lRetorno = "venClientesXLSCatalogoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
