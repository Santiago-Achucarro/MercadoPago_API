using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 23 de julio de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesChequerasChequesActionEnum
        {            public enum EnumtesChequerasChequesAction
            {
                Datos
            }
        public static string GetAcciontesChequerasChequesAction(tesChequerasChequesActionEnum.EnumtesChequerasChequesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesChequerasChequesActionEnum.EnumtesChequerasChequesAction.Datos: lRetorno = "tesChequerasChequesDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
