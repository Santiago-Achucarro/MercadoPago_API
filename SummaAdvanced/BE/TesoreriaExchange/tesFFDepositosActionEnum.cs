using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 21 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesFFDepositosActionEnum
        {            public enum EnumtesFFDepositosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesFFDepositosAction(tesFFDepositosActionEnum.EnumtesFFDepositosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesFFDepositosActionEnum.EnumtesFFDepositosAction.Guardar: lRetorno = "tesFFDepositosGuardar"; break;
                case tesFFDepositosActionEnum.EnumtesFFDepositosAction.Datos: lRetorno = "tesFFDepositosDevolverDatos"; break;
                case tesFFDepositosActionEnum.EnumtesFFDepositosAction.Eliminar: lRetorno = "tesFFDepositosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
