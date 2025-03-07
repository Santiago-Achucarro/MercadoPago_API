using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 17 de septiembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genContadorCopiarActionEnum
        {            public enum EnumgenContadorCopiarAction
            {
                Guardar
            }
        public static string GetAcciongenContadorCopiarAction(genContadorCopiarActionEnum.EnumgenContadorCopiarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genContadorCopiarActionEnum.EnumgenContadorCopiarAction.Guardar: lRetorno = "genContadorCopiarGuardar"; break;
            }
            return lRetorno;
        }
    }
}
