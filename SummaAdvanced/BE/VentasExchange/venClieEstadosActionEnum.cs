using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venClieEstadosActionEnum
        {            public enum EnumvenClieEstadosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenClieEstadosAction(venClieEstadosActionEnum.EnumvenClieEstadosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venClieEstadosActionEnum.EnumvenClieEstadosAction.Guardar: lRetorno = "venClieEstadosGuardar"; break;
                case venClieEstadosActionEnum.EnumvenClieEstadosAction.Datos: lRetorno = "venClieEstadosDevolverDatos"; break;
                case venClieEstadosActionEnum.EnumvenClieEstadosAction.Eliminar: lRetorno = "venClieEstadosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
