using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Wednesday, August 21, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class suePersonalXLSActionEnum
        {            public enum EnumsuePersonalXLSAction
            {
                Guardar
            }
        public static string GetAccionsuePersonalXLSAction(suePersonalXLSActionEnum.EnumsuePersonalXLSAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case suePersonalXLSActionEnum.EnumsuePersonalXLSAction.Guardar: lRetorno = "suePersonalXLSGuardar"; break;
            }
            return lRetorno;
        }
    }
}
