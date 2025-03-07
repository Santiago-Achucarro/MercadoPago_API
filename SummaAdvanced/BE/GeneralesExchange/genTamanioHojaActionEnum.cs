using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, December 16, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genTamanioHojaActionEnum
        {            public enum EnumgenTamanioHojaAction
            {
                Datos
            }
        public static string GetAcciongenTamanioHojaAction(genTamanioHojaActionEnum.EnumgenTamanioHojaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genTamanioHojaActionEnum.EnumgenTamanioHojaAction.Datos: lRetorno = "genTamanioHojaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
