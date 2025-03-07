using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 7 de septiembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impValidacionFComprasActionEnum
        {            public enum EnumimpValidacionFComprasAction
            {
                Datos
            }
        public static string GetAccionimpValidacionFComprasAction(impValidacionFComprasActionEnum.EnumimpValidacionFComprasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impValidacionFComprasActionEnum.EnumimpValidacionFComprasAction.Datos: lRetorno = "impValidacionFComprasDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
