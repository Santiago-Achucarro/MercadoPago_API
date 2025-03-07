using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proRecetasRecursosActionEnum
        {            public enum EnumproRecetasRecursosAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionproRecetasRecursosAction(proRecetasRecursosActionEnum.EnumproRecetasRecursosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proRecetasRecursosActionEnum.EnumproRecetasRecursosAction.Guardar: lRetorno = "proRecetasRecursosGuardar"; break;
                case proRecetasRecursosActionEnum.EnumproRecetasRecursosAction.Eliminar: lRetorno = "proRecetasRecursosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
