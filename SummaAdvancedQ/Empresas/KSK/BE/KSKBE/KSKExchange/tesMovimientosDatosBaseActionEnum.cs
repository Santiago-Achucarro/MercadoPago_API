using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, October 27, 2023
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange{
        public static class tesMovimientosDatosBaseActionEnum
        {            public enum EnumtesMovimientosDatosBaseAction
            {
                Eliminar
            }
        public static string GetAcciontesMovimientosDatosBaseAction(tesMovimientosDatosBaseActionEnum.EnumtesMovimientosDatosBaseAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesMovimientosDatosBaseActionEnum.EnumtesMovimientosDatosBaseAction.Eliminar: lRetorno = "tesMovimientosDatosBaseEliminar"; break;
            }
            return lRetorno;
        }
    }
}
