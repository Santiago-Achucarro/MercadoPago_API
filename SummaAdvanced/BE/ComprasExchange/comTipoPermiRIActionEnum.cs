using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, September 10, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comTipoPermiRIActionEnum
        {            public enum EnumcomTipoPermiRIAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomTipoPermiRIAction(comTipoPermiRIActionEnum.EnumcomTipoPermiRIAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comTipoPermiRIActionEnum.EnumcomTipoPermiRIAction.Guardar: lRetorno = "comTipoPermiRIGuardar"; break;
                case comTipoPermiRIActionEnum.EnumcomTipoPermiRIAction.Datos: lRetorno = "comTipoPermiRIDevolverDatos"; break;
                case comTipoPermiRIActionEnum.EnumcomTipoPermiRIAction.Eliminar: lRetorno = "comTipoPermiRIEliminar"; break;
            }
            return lRetorno;
        }
    }
}
