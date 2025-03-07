using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 25 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conArbolAsientosActionEnum
        {            public enum EnumconArbolAsientosAction
            {
                Datos,Resumen,Detalle
            }
        public static string GetAccionconArbolAsientosAction(conArbolAsientosActionEnum.EnumconArbolAsientosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conArbolAsientosActionEnum.EnumconArbolAsientosAction.Datos: lRetorno = "conArbolAsientosDevolverDatos"; break;
                case conArbolAsientosActionEnum.EnumconArbolAsientosAction.Resumen: lRetorno = "conArbolAsientosResumen"; break;
                case conArbolAsientosActionEnum.EnumconArbolAsientosAction.Detalle: lRetorno = "conArbolAsientosDetalle"; break;
            }
            return lRetorno;
        }
    }
}
