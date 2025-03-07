using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 08 de septiembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesteoExchange{
        public static class espvenCondFiscImpTestActionEnum
        {            public enum EnumespvenCondFiscImpTestAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionespvenCondFiscImpTestAction(espvenCondFiscImpTestActionEnum.EnumespvenCondFiscImpTestAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espvenCondFiscImpTestActionEnum.EnumespvenCondFiscImpTestAction.Guardar: lRetorno = "espvenCondFiscImpTestGuardar"; break;
                case espvenCondFiscImpTestActionEnum.EnumespvenCondFiscImpTestAction.Datos: lRetorno = "espvenCondFiscImpTestDevolverDatos"; break;
                case espvenCondFiscImpTestActionEnum.EnumespvenCondFiscImpTestAction.Eliminar: lRetorno = "espvenCondFiscImpTestEliminar"; break;
            }
            return lRetorno;
        }
    }
}
