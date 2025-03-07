using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 9 de mayo de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venListasCopiarActionEnum
        {            public enum EnumvenListasCopiarAction
            {
                Guardar
            }
        public static string GetAccionvenListasCopiarAction(venListasCopiarActionEnum.EnumvenListasCopiarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venListasCopiarActionEnum.EnumvenListasCopiarAction.Guardar: lRetorno = "venListasCopiarGuardar"; break;
            }
            return lRetorno;
        }
    }
}
