using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 21 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesFFPagosProvedoresActionEnum
        {            public enum EnumtesFFPagosProvedoresAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesFFPagosProvedoresAction(tesFFPagosProvedoresActionEnum.EnumtesFFPagosProvedoresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesFFPagosProvedoresActionEnum.EnumtesFFPagosProvedoresAction.Guardar: lRetorno = "tesFFPagosProvedoresGuardar"; break;
                case tesFFPagosProvedoresActionEnum.EnumtesFFPagosProvedoresAction.Datos: lRetorno = "tesFFPagosProvedoresDevolverDatos"; break;
                case tesFFPagosProvedoresActionEnum.EnumtesFFPagosProvedoresAction.Eliminar: lRetorno = "tesFFPagosProvedoresEliminar"; break;
            }
            return lRetorno;
        }
    }
}
