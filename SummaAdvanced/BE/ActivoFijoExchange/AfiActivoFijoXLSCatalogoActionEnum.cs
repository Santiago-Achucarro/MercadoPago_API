using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 12 de agosto de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ActivoFijoExchange{
        public static class AfiActivoFijoXLSCatalogoActionEnum
        {            public enum EnumAfiActivoFijoXLSCatalogoAction
            {
                Datos
            }
        public static string GetAccionAfiActivoFijoXLSCatalogoAction(AfiActivoFijoXLSCatalogoActionEnum.EnumAfiActivoFijoXLSCatalogoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case AfiActivoFijoXLSCatalogoActionEnum.EnumAfiActivoFijoXLSCatalogoAction.Datos: lRetorno = "AfiActivoFijoXLSCatalogoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
