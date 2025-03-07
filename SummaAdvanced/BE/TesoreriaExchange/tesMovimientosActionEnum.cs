using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 26 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesMovimientosActionEnum
        {            public enum EnumtesMovimientosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesMovimientosAction(tesMovimientosActionEnum.EnumtesMovimientosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesMovimientosActionEnum.EnumtesMovimientosAction.Guardar: lRetorno = "tesMovimientosGuardar"; break;
                case tesMovimientosActionEnum.EnumtesMovimientosAction.Datos: lRetorno = "tesMovimientosDevolverDatos"; break;
                case tesMovimientosActionEnum.EnumtesMovimientosAction.Eliminar: lRetorno = "tesMovimientosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
