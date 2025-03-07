using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 27 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comRemiPendFactActionEnum
        {            public enum EnumcomRemiPendFactAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomRemiPendFactAction(comRemiPendFactActionEnum.EnumcomRemiPendFactAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comRemiPendFactActionEnum.EnumcomRemiPendFactAction.Guardar: lRetorno = "comRemiPendFactGuardar"; break;
                case comRemiPendFactActionEnum.EnumcomRemiPendFactAction.Datos: lRetorno = "comRemiPendFactDevolverDatos"; break;
                case comRemiPendFactActionEnum.EnumcomRemiPendFactAction.Eliminar: lRetorno = "comRemiPendFactEliminar"; break;
            }
            return lRetorno;
        }
    }
}
