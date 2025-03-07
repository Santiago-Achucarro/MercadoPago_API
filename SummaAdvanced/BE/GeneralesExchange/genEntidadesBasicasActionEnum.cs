using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 25 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genEntidadesBasicasActionEnum
        {            public enum EnumgenEntidadesBasicasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenEntidadesBasicasAction(genEntidadesBasicasActionEnum.EnumgenEntidadesBasicasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genEntidadesBasicasActionEnum.EnumgenEntidadesBasicasAction.Guardar: lRetorno = "genEntidadesBasicasGuardar"; break;
                case genEntidadesBasicasActionEnum.EnumgenEntidadesBasicasAction.Datos: lRetorno = "genEntidadesBasicasDevolverDatos"; break;
                case genEntidadesBasicasActionEnum.EnumgenEntidadesBasicasAction.Eliminar: lRetorno = "genEntidadesBasicasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
