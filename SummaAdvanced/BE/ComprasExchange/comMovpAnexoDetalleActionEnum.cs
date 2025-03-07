using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de septiembre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovpAnexoDetalleActionEnum
        {            public enum EnumcomMovpAnexoDetalleAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomMovpAnexoDetalleAction(comMovpAnexoDetalleActionEnum.EnumcomMovpAnexoDetalleAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovpAnexoDetalleActionEnum.EnumcomMovpAnexoDetalleAction.Guardar: lRetorno = "comMovpAnexoDetalleGuardar"; break;
                case comMovpAnexoDetalleActionEnum.EnumcomMovpAnexoDetalleAction.Datos: lRetorno = "comMovpAnexoDetalleDevolverDatos"; break;
                case comMovpAnexoDetalleActionEnum.EnumcomMovpAnexoDetalleAction.Eliminar: lRetorno = "comMovpAnexoDetalleEliminar"; break;
            }
            return lRetorno;
        }
    }
}
