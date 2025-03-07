using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 2 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conAsientosAnulActionEnum
        {            public enum EnumconAsientosAnulAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconAsientosAnulAction(conAsientosAnulActionEnum.EnumconAsientosAnulAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conAsientosAnulActionEnum.EnumconAsientosAnulAction.Guardar: lRetorno = "conAsientosAnulGuardar"; break;
                case conAsientosAnulActionEnum.EnumconAsientosAnulAction.Datos: lRetorno = "conAsientosAnulDevolverDatos"; break;
                case conAsientosAnulActionEnum.EnumconAsientosAnulAction.Eliminar: lRetorno = "conAsientosAnulEliminar"; break;
            }
            return lRetorno;
        }
    }
}
