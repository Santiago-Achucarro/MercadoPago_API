using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 5 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCheqTercerosCambioActionEnum
        {            public enum EnumtesCheqTercerosCambioAction
            {
                TraeCheques, Guardar    
            }
        public static string GetAcciontesCheqTercerosCambioAction(tesCheqTercerosCambioActionEnum.EnumtesCheqTercerosCambioAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCheqTercerosCambioActionEnum.EnumtesCheqTercerosCambioAction.TraeCheques: lRetorno = "tesCheqTercerosCambioTraeCheques"; break;
                case tesCheqTercerosCambioActionEnum.EnumtesCheqTercerosCambioAction.Guardar: lRetorno = "tesCheqTercerosCambioGuardar"; break;
            }
            return lRetorno;
        }
    }
}
