using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 8 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovImpuestosActionEnum
        {            public enum EnumvenMovImpuestosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMovImpuestosAction(venMovImpuestosActionEnum.EnumvenMovImpuestosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovImpuestosActionEnum.EnumvenMovImpuestosAction.Guardar: lRetorno = "venMovImpuestosGuardar"; break;
                case venMovImpuestosActionEnum.EnumvenMovImpuestosAction.Datos: lRetorno = "venMovImpuestosDevolverDatos"; break;
                case venMovImpuestosActionEnum.EnumvenMovImpuestosAction.Eliminar: lRetorno = "venMovImpuestosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
