using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 14 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proRecetasCambioProductoActionEnum
        {            public enum EnumproRecetasCambioProductoAction
            {
                Guardar
            }
        public static string GetAccionproRecetasCambioProductoAction(proRecetasCambioProductoActionEnum.EnumproRecetasCambioProductoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proRecetasCambioProductoActionEnum.EnumproRecetasCambioProductoAction.Guardar: lRetorno = "proRecetasCambioProductoGuardar"; break;
            }
            return lRetorno;
        }
    }
}
