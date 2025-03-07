using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 9 de diciembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conInfDefFilasActionEnum
        {            public enum EnumconInfDefFilasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconInfDefFilasAction(conInfDefFilasActionEnum.EnumconInfDefFilasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conInfDefFilasActionEnum.EnumconInfDefFilasAction.Guardar: lRetorno = "conInfDefFilasGuardar"; break;
                case conInfDefFilasActionEnum.EnumconInfDefFilasAction.Datos: lRetorno = "conInfDefFilasDevolverDatos"; break;
                case conInfDefFilasActionEnum.EnumconInfDefFilasAction.Eliminar: lRetorno = "conInfDefFilasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
