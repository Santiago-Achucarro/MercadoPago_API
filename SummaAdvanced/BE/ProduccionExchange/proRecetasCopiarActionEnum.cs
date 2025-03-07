using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 13 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proRecetasCopiarActionEnum
        {            public enum EnumproRecetasCopiarAction
            {
                Guardar
            }
        public static string GetAccionproRecetasCopiarAction(proRecetasCopiarActionEnum.EnumproRecetasCopiarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proRecetasCopiarActionEnum.EnumproRecetasCopiarAction.Guardar: lRetorno = "proRecetasCopiarGuardar"; break;
            }
            return lRetorno;
        }
    }
}
