using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 4 de junio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesAIChequesActionEnum
        {            public enum EnumtesAIChequesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesAIChequesAction(tesAIChequesActionEnum.EnumtesAIChequesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesAIChequesActionEnum.EnumtesAIChequesAction.Guardar: lRetorno = "tesAIChequesGuardar"; break;
                case tesAIChequesActionEnum.EnumtesAIChequesAction.Datos: lRetorno = "tesAIChequesDevolverDatos"; break;
                case tesAIChequesActionEnum.EnumtesAIChequesAction.Eliminar: lRetorno = "tesAIChequesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
