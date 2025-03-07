using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 12 de agosto de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venListasPreciosXLSCatalogoActionEnum
        {            public enum EnumvenListasPreciosXLSCatalogoAction
            {
                Datos
            }
        public static string GetAccionvenListasPreciosXLSCatalogoAction(venListasPreciosXLSCatalogoActionEnum.EnumvenListasPreciosXLSCatalogoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venListasPreciosXLSCatalogoActionEnum.EnumvenListasPreciosXLSCatalogoAction.Datos: lRetorno = "venListasPreciosXLSCatalogoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
