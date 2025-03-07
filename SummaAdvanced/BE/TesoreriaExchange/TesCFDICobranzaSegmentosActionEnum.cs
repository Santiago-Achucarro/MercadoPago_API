using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 8 de junio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class TesCFDICobranzaSegmentosActionEnum
        {            public enum EnumTesCFDICobranzaSegmentosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionTesCFDICobranzaSegmentosAction(TesCFDICobranzaSegmentosActionEnum.EnumTesCFDICobranzaSegmentosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case TesCFDICobranzaSegmentosActionEnum.EnumTesCFDICobranzaSegmentosAction.Guardar: lRetorno = "TesCFDICobranzaSegmentosGuardar"; break;
                case TesCFDICobranzaSegmentosActionEnum.EnumTesCFDICobranzaSegmentosAction.Datos: lRetorno = "TesCFDICobranzaSegmentosDevolverDatos"; break;
                case TesCFDICobranzaSegmentosActionEnum.EnumTesCFDICobranzaSegmentosAction.Eliminar: lRetorno = "TesCFDICobranzaSegmentosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
