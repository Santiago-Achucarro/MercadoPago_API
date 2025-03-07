using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 3 de septiembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCheqPropDebitarCDActionEnum
        {            public enum EnumtesCheqPropDebitarCDAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesCheqPropDebitarCDAction(tesCheqPropDebitarCDActionEnum.EnumtesCheqPropDebitarCDAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCheqPropDebitarCDActionEnum.EnumtesCheqPropDebitarCDAction.Guardar: lRetorno = "tesCheqPropDebitarCDGuardar"; break;
                case tesCheqPropDebitarCDActionEnum.EnumtesCheqPropDebitarCDAction.Datos: lRetorno = "tesCheqPropDebitarCDDevolverDatos"; break;
                case tesCheqPropDebitarCDActionEnum.EnumtesCheqPropDebitarCDAction.Eliminar: lRetorno = "tesCheqPropDebitarCDEliminar"; break;
            }
            return lRetorno;
        }
    }
}
