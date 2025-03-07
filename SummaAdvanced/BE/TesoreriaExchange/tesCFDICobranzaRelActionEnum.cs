using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 8 de junio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesCFDICobranzaRelActionEnum
        {            public enum EnumtesCFDICobranzaRelAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesCFDICobranzaRelAction(tesCFDICobranzaRelActionEnum.EnumtesCFDICobranzaRelAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesCFDICobranzaRelActionEnum.EnumtesCFDICobranzaRelAction.Guardar: lRetorno = "tesCFDICobranzaRelGuardar"; break;
                case tesCFDICobranzaRelActionEnum.EnumtesCFDICobranzaRelAction.Datos: lRetorno = "tesCFDICobranzaRelDevolverDatos"; break;
                case tesCFDICobranzaRelActionEnum.EnumtesCFDICobranzaRelAction.Eliminar: lRetorno = "tesCFDICobranzaRelEliminar"; break;
            }
            return lRetorno;
        }
    }
}
