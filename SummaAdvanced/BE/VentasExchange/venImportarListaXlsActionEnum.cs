using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 21 de septiembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venImportarListaXlsActionEnum
        {            public enum EnumvenImportarListaXlsAction
            {
                Guardar
            }
        public static string GetAccionvenImportarListaXlsAction(venImportarListaXlsActionEnum.EnumvenImportarListaXlsAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venImportarListaXlsActionEnum.EnumvenImportarListaXlsAction.Guardar: lRetorno = "venImportarListaXlsGuardar"; break;
            }
            return lRetorno;
        }
    }
}
