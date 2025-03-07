using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de septiembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovimientosCRExpMxActionEnum
        {            public enum EnumvenMovimientosCRExpMxAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMovimientosCRExpMxAction(venMovimientosCRExpMxActionEnum.EnumvenMovimientosCRExpMxAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovimientosCRExpMxActionEnum.EnumvenMovimientosCRExpMxAction.Guardar: lRetorno = "venMovimientosCRExpMxGuardar"; break;
                case venMovimientosCRExpMxActionEnum.EnumvenMovimientosCRExpMxAction.Datos: lRetorno = "venMovimientosCRExpMxDevolverDatos"; break;
                case venMovimientosCRExpMxActionEnum.EnumvenMovimientosCRExpMxAction.Eliminar: lRetorno = "venMovimientosCRExpMxEliminar"; break;
            }
            return lRetorno;
        }
    }
}
