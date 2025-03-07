using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 16 de septiembre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovSSImpuestosActionEnum
        {            public enum EnumvenMovSSImpuestosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMovSSImpuestosAction(venMovSSImpuestosActionEnum.EnumvenMovSSImpuestosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovSSImpuestosActionEnum.EnumvenMovSSImpuestosAction.Guardar: lRetorno = "venMovSSImpuestosGuardar"; break;
                case venMovSSImpuestosActionEnum.EnumvenMovSSImpuestosAction.Datos: lRetorno = "venMovSSImpuestosDevolverDatos"; break;
                case venMovSSImpuestosActionEnum.EnumvenMovSSImpuestosAction.Eliminar: lRetorno = "venMovSSImpuestosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
