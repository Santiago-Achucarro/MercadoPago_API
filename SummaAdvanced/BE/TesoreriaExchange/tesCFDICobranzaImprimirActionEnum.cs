using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de junio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCFDICobranzaImprimirActionEnum
        {            public enum EnumtesCFDICobranzaImprimirAction
            {
                Guardar,Datos,AsignarNombre
            }
        public static string GetAcciontesCFDICobranzaImprimirAction(tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction.Guardar: lRetorno = "tesCFDICobranzaImprimirGuardar"; break;
                case tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction.Datos: lRetorno = "tesCFDICobranzaImprimirDevolverDatos"; break;
                case tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction.AsignarNombre: lRetorno = "tesCFDICobranzaImprimirAsignarNombre"; break;
            }
            return lRetorno;
        }
    }
}
