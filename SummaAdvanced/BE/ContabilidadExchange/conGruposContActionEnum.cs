using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 21 de octubre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conGruposContActionEnum
        {            public enum EnumconGruposContAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconGruposContAction(conGruposContActionEnum.EnumconGruposContAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conGruposContActionEnum.EnumconGruposContAction.Guardar: lRetorno = "conGruposContGuardar"; break;
                case conGruposContActionEnum.EnumconGruposContAction.Datos: lRetorno = "conGruposContDevolverDatos"; break;
                case conGruposContActionEnum.EnumconGruposContAction.Eliminar: lRetorno = "conGruposContEliminar"; break;
            }
            return lRetorno;
        }
    }
}
