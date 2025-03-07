using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 26 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCheqPropActionEnum
        {            public enum EnumtesCheqPropAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesCheqPropAction(tesCheqPropActionEnum.EnumtesCheqPropAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCheqPropActionEnum.EnumtesCheqPropAction.Guardar: lRetorno = "tesCheqPropGuardar"; break;
                case tesCheqPropActionEnum.EnumtesCheqPropAction.Datos: lRetorno = "tesCheqPropDevolverDatos"; break;
                case tesCheqPropActionEnum.EnumtesCheqPropAction.Eliminar: lRetorno = "tesCheqPropEliminar"; break;
            }
            return lRetorno;
        }
    }
}
