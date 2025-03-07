using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 31 de marzo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCheqPropImpresionActionEnum
        {            public enum EnumtesCheqPropImpresionAction
            {
                Datos
            }
        public static string GetAcciontesCheqPropImpresionAction(tesCheqPropImpresionActionEnum.EnumtesCheqPropImpresionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCheqPropImpresionActionEnum.EnumtesCheqPropImpresionAction.Datos: lRetorno = "tesCheqPropImpresionDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
