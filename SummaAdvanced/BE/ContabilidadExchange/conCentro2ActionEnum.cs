using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 14 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conCentro2ActionEnum
        {            public enum EnumconCentro2Action
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconCentro2Action(conCentro2ActionEnum.EnumconCentro2Action pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conCentro2ActionEnum.EnumconCentro2Action.Guardar: lRetorno = "conCentro2Guardar"; break;
                case conCentro2ActionEnum.EnumconCentro2Action.Datos: lRetorno = "conCentro2DevolverDatos"; break;
                case conCentro2ActionEnum.EnumconCentro2Action.Eliminar: lRetorno = "conCentro2Eliminar"; break;
            }
            return lRetorno;
        }
    }
}
