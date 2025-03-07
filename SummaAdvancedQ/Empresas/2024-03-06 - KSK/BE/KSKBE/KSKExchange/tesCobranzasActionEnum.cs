using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, October 27, 2023
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class tesCobranzasActionEnum
        {            public enum EnumtesCobranzasAction
            {
                Eliminar
            }
        public static string GetAcciontesCobranzasAction(tesCobranzasActionEnum.EnumtesCobranzasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCobranzasActionEnum.EnumtesCobranzasAction.Eliminar: lRetorno = "tesCobranzasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
