using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de septiembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovimientosExpMXActionEnum
        {            public enum EnumvenMovimientosExpMXAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMovimientosExpMXAction(venMovimientosExpMXActionEnum.EnumvenMovimientosExpMXAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosExpMXActionEnum.EnumvenMovimientosExpMXAction.Guardar: lRetorno = "venMovimientosExpMXGuardar"; break;
                case venMovimientosExpMXActionEnum.EnumvenMovimientosExpMXAction.Datos: lRetorno = "venMovimientosExpMXDevolverDatos"; break;
                case venMovimientosExpMXActionEnum.EnumvenMovimientosExpMXAction.Eliminar: lRetorno = "venMovimientosExpMXEliminar"; break;
            }
            return lRetorno;
        }
    }
}
