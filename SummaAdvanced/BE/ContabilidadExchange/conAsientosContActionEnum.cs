using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 19 de octubre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conAsientosContActionEnum
        {            public enum EnumconAsientosContAction
            {
                Guardar,Datos,Eliminar,CalcularTotales,TraerTipo,SubirXLS
            }
        public static string GetAccionconAsientosContAction(conAsientosContActionEnum.EnumconAsientosContAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conAsientosContActionEnum.EnumconAsientosContAction.Guardar: lRetorno = "conAsientosContGuardar"; break;
                case conAsientosContActionEnum.EnumconAsientosContAction.Datos: lRetorno = "conAsientosContDevolverDatos"; break;
                case conAsientosContActionEnum.EnumconAsientosContAction.Eliminar: lRetorno = "conAsientosContEliminar"; break;
                case conAsientosContActionEnum.EnumconAsientosContAction.CalcularTotales: lRetorno = "conAsientosContCalcularTotales"; break;
                case conAsientosContActionEnum.EnumconAsientosContAction.TraerTipo: lRetorno = "conAsientosContTraerTipo"; break;
                case conAsientosContActionEnum.EnumconAsientosContAction.SubirXLS: lRetorno = "conAsientosContSubirXLS"; break;
            }
            return lRetorno;
        }
    }
}
