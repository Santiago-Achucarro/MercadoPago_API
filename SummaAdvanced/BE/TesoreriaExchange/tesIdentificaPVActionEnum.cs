using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 23 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesIdentificaPVActionEnum
        {            public enum EnumtesIdentificaPVAction
            {
                TraerMediosPago
            }
        public static string GetAcciontesIdentificaPVAction(tesIdentificaPVActionEnum.EnumtesIdentificaPVAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesIdentificaPVActionEnum.EnumtesIdentificaPVAction.TraerMediosPago: lRetorno = "tesIdentificaPVTraerMediosPago"; break;
            }
            return lRetorno;
        }
    }
}
