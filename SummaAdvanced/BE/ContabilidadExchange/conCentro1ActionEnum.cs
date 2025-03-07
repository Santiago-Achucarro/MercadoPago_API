using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, mayo 19, 2016    
/// <summary> 
/// Solo para Enumerar la Posibles Acciones    
/// </summary>
/// 
namespace ContabilidadExchange
{
    public static class conCentro1ActionEnum
    {
        public enum EnumconCentro1Action
        {
            Guardar, Datos, Eliminar
        }
        public static string GetAccionconCentro1Action(conCentro1ActionEnum.EnumconCentro1Action pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conCentro1ActionEnum.EnumconCentro1Action.Guardar: lRetorno = "conCentro1Guardar"; break;
                case conCentro1ActionEnum.EnumconCentro1Action.Datos: lRetorno = "conCentro1DevolverDatos"; break;
                case conCentro1ActionEnum.EnumconCentro1Action.Eliminar: lRetorno = "conCentro1Eliminar"; break;
            }
            return lRetorno;
        }
    }
}
