using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 15 de julio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venClientesImportarXlsActionEnum
        {            public enum EnumvenClientesImportarXlsAction
            {
                Guardar
            }
        public static string GetAccionvenClientesImportarXlsAction(venClientesImportarXlsActionEnum.EnumvenClientesImportarXlsAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venClientesImportarXlsActionEnum.EnumvenClientesImportarXlsAction.Guardar: lRetorno = "venClientesImportarXlsGuardar"; break;
            }
            return lRetorno;
        }
    }
}
