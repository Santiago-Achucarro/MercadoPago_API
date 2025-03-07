using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 19 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesIdentificaActionEnum
        {            public enum EnumtesIdentificaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesIdentificaAction(tesIdentificaActionEnum.EnumtesIdentificaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesIdentificaActionEnum.EnumtesIdentificaAction.Guardar: lRetorno = "tesIdentificaGuardar"; break;
                case tesIdentificaActionEnum.EnumtesIdentificaAction.Datos: lRetorno = "tesIdentificaDevolverDatos"; break;
                case tesIdentificaActionEnum.EnumtesIdentificaAction.Eliminar: lRetorno = "tesIdentificaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
