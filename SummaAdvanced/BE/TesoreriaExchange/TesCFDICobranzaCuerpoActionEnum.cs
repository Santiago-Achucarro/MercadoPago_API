using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 8 de junio de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class TesCFDICobranzaCuerpoActionEnum
        {            public enum EnumTesCFDICobranzaCuerpoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionTesCFDICobranzaCuerpoAction(TesCFDICobranzaCuerpoActionEnum.EnumTesCFDICobranzaCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case TesCFDICobranzaCuerpoActionEnum.EnumTesCFDICobranzaCuerpoAction.Guardar: lRetorno = "TesCFDICobranzaCuerpoGuardar"; break;
                case TesCFDICobranzaCuerpoActionEnum.EnumTesCFDICobranzaCuerpoAction.Datos: lRetorno = "TesCFDICobranzaCuerpoDevolverDatos"; break;
                case TesCFDICobranzaCuerpoActionEnum.EnumTesCFDICobranzaCuerpoAction.Eliminar: lRetorno = "TesCFDICobranzaCuerpoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
