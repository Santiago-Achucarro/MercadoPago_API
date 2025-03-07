using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 27 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genMovimientosActionEnum
        {            public enum EnumgenMovimientosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenMovimientosAction(genMovimientosActionEnum.EnumgenMovimientosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genMovimientosActionEnum.EnumgenMovimientosAction.Guardar: lRetorno = "genMovimientosGuardar"; break;
                case genMovimientosActionEnum.EnumgenMovimientosAction.Datos: lRetorno = "genMovimientosDevolverDatos"; break;
                case genMovimientosActionEnum.EnumgenMovimientosAction.Eliminar: lRetorno = "genMovimientosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
