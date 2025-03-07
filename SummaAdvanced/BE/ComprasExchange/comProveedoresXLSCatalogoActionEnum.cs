using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 12 de agosto de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comProveedoresXLSCatalogoActionEnum
        {            public enum EnumcomProveedoresXLSCatalogoAction
            {
                Datos
            }
        public static string GetAccioncomProveedoresXLSCatalogoAction(comProveedoresXLSCatalogoActionEnum.EnumcomProveedoresXLSCatalogoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comProveedoresXLSCatalogoActionEnum.EnumcomProveedoresXLSCatalogoAction.Datos: lRetorno = "comProveedoresXLSCatalogoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
