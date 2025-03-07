using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 8 de junio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCFDICobranzaActionEnum
        {            public enum EnumtesCFDICobranzaAction
            {
                Guardar,Datos,Eliminar,DatosInt
        }
        public static string GetAcciontesCFDICobranzaAction(tesCFDICobranzaActionEnum.EnumtesCFDICobranzaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCFDICobranzaActionEnum.EnumtesCFDICobranzaAction.Guardar: lRetorno = "tesCFDICobranzaGuardar"; break;
                case tesCFDICobranzaActionEnum.EnumtesCFDICobranzaAction.Datos: lRetorno = "tesCFDICobranzaDevolverDatos"; break;
                case tesCFDICobranzaActionEnum.EnumtesCFDICobranzaAction.Eliminar: lRetorno = "tesCFDICobranzaEliminar"; break;
                case tesCFDICobranzaActionEnum.EnumtesCFDICobranzaAction.DatosInt: lRetorno = "tesCFDICobranzaDatosInt"; break;

            }
            return lRetorno;
        }
    }
}
