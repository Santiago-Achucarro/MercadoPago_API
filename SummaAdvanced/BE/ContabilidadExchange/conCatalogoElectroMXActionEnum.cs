using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 13 de diciembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conCatalogoElectroMXActionEnum
        {            public enum EnumconCatalogoElectroMXAction
            {
                Guardar,Datos
            }
        public static string GetAccionconCatalogoElectroMXAction(conCatalogoElectroMXActionEnum.EnumconCatalogoElectroMXAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conCatalogoElectroMXActionEnum.EnumconCatalogoElectroMXAction.Guardar: lRetorno = "conCatalogoElectroMXGuardar"; break;
                case conCatalogoElectroMXActionEnum.EnumconCatalogoElectroMXAction.Datos: lRetorno = "conCatalogoElectroMXDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
