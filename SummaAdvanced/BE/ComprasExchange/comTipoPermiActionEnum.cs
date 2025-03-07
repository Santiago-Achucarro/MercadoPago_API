using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Thursday, October 17, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comTipoPermiActionEnum
        {            public enum EnumcomTipoPermiAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomTipoPermiAction(comTipoPermiActionEnum.EnumcomTipoPermiAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comTipoPermiActionEnum.EnumcomTipoPermiAction.Guardar: lRetorno = "comTipoPermiGuardar"; break;
                case comTipoPermiActionEnum.EnumcomTipoPermiAction.Datos: lRetorno = "comTipoPermiDevolverDatos"; break;
                case comTipoPermiActionEnum.EnumcomTipoPermiAction.Eliminar: lRetorno = "comTipoPermiEliminar"; break;
            }
            return lRetorno;
        }
    }
}
