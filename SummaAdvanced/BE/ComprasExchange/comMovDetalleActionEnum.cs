using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 27 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovDetalleActionEnum
        {            public enum EnumcomMovDetalleAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomMovDetalleAction(comMovDetalleActionEnum.EnumcomMovDetalleAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovDetalleActionEnum.EnumcomMovDetalleAction.Guardar: lRetorno = "comMovDetalleGuardar"; break;
                case comMovDetalleActionEnum.EnumcomMovDetalleAction.Datos: lRetorno = "comMovDetalleDevolverDatos"; break;
                case comMovDetalleActionEnum.EnumcomMovDetalleAction.Eliminar: lRetorno = "comMovDetalleEliminar"; break;
            }
            return lRetorno;
        }
    }
}
