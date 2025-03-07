using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 4 de junio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesAIDepositosActionEnum
        {            public enum EnumtesAIDepositosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesAIDepositosAction(tesAIDepositosActionEnum.EnumtesAIDepositosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesAIDepositosActionEnum.EnumtesAIDepositosAction.Guardar: lRetorno = "tesAIDepositosGuardar"; break;
                case tesAIDepositosActionEnum.EnumtesAIDepositosAction.Datos: lRetorno = "tesAIDepositosDevolverDatos"; break;
                case tesAIDepositosActionEnum.EnumtesAIDepositosAction.Eliminar: lRetorno = "tesAIDepositosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
