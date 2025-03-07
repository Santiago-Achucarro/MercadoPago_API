using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 16 de septiembre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovCSImpuestosActionEnum
        {            public enum EnumvenMovCSImpuestosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMovCSImpuestosAction(venMovCSImpuestosActionEnum.EnumvenMovCSImpuestosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovCSImpuestosActionEnum.EnumvenMovCSImpuestosAction.Guardar: lRetorno = "venMovCSImpuestosGuardar"; break;
                case venMovCSImpuestosActionEnum.EnumvenMovCSImpuestosAction.Datos: lRetorno = "venMovCSImpuestosDevolverDatos"; break;
                case venMovCSImpuestosActionEnum.EnumvenMovCSImpuestosAction.Eliminar: lRetorno = "venMovCSImpuestosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
