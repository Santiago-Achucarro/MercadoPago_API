using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venFormaEntregaActionEnum
        {            public enum EnumvenFormaEntregaAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenFormaEntregaAction(venFormaEntregaActionEnum.EnumvenFormaEntregaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venFormaEntregaActionEnum.EnumvenFormaEntregaAction.Guardar: lRetorno = "venFormaEntregaGuardar"; break;
                case venFormaEntregaActionEnum.EnumvenFormaEntregaAction.Datos: lRetorno = "venFormaEntregaDevolverDatos"; break;
                case venFormaEntregaActionEnum.EnumvenFormaEntregaAction.Eliminar: lRetorno = "venFormaEntregaEliminar"; break;
            }
            return lRetorno;
        }
    }
}
