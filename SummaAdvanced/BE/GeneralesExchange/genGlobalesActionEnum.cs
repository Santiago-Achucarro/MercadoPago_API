using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 28 de mayo de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange
{
    public static class genGlobalesActionEnum
    {
        public enum EnumgenGlobalesAction
        {
            Guardar, Datos, Eliminar, Set
        }
        public static string GetAcciongenGlobalesAction(genGlobalesActionEnum.EnumgenGlobalesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genGlobalesActionEnum.EnumgenGlobalesAction.Guardar: lRetorno = "genGlobalesGuardar"; break;
                case genGlobalesActionEnum.EnumgenGlobalesAction.Datos: lRetorno = "genGlobalesDevolverDatos"; break;
                case genGlobalesActionEnum.EnumgenGlobalesAction.Eliminar: lRetorno = "genGlobalesEliminar"; break;
                case genGlobalesActionEnum.EnumgenGlobalesAction.Set: lRetorno = "genGlobalesSet"; break;
            }
            return lRetorno;
        }
    }
}
