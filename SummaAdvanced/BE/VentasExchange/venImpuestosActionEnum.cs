using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venImpuestosActionEnum
        {            public enum EnumvenImpuestosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenImpuestosAction(venImpuestosActionEnum.EnumvenImpuestosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venImpuestosActionEnum.EnumvenImpuestosAction.Guardar: lRetorno = "venImpuestosGuardar"; break;
                case venImpuestosActionEnum.EnumvenImpuestosAction.Datos: lRetorno = "venImpuestosDevolverDatos"; break;
                case venImpuestosActionEnum.EnumvenImpuestosAction.Eliminar: lRetorno = "venImpuestosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
