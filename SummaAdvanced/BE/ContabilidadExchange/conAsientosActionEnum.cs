using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 25 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conAsientosActionEnum
        {            public enum EnumconAsientosAction
            {
                Guardar,Datos,Eliminar,Anular, Agregar, DatosInt, Postear
        }
        public static string GetAccionconAsientosAction(conAsientosActionEnum.EnumconAsientosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conAsientosActionEnum.EnumconAsientosAction.Guardar: lRetorno = "conAsientosGuardar"; break;
                case conAsientosActionEnum.EnumconAsientosAction.Datos: lRetorno = "conAsientosDevolverDatos"; break;
                case conAsientosActionEnum.EnumconAsientosAction.Eliminar: lRetorno = "conAsientosEliminar"; break;
                case conAsientosActionEnum.EnumconAsientosAction.Anular: lRetorno = "conAsientosAnular"; break;
                case conAsientosActionEnum.EnumconAsientosAction.Agregar: lRetorno = "conAsientosAgregar"; break;
                case conAsientosActionEnum.EnumconAsientosAction.DatosInt: lRetorno = "conAsientosDatosInt"; break;
                case conAsientosActionEnum.EnumconAsientosAction.Postear: lRetorno = "conAsientosPostear"; break;

            }
            return lRetorno;
        }
    }
}
