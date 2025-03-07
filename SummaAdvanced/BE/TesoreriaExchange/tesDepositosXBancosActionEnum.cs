using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 7 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesDepositosXBancosActionEnum
        {            public enum EnumtesDepositosXBancosAction
            {
                Guardar,Datos
            }
        public static string GetAcciontesDepositosXBancosAction(tesDepositosXBancosActionEnum.EnumtesDepositosXBancosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesDepositosXBancosActionEnum.EnumtesDepositosXBancosAction.Guardar: lRetorno = "tesDepositosXBancosGuardar"; break;
                case tesDepositosXBancosActionEnum.EnumtesDepositosXBancosAction.Datos: lRetorno = "tesDepositosXBancosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
