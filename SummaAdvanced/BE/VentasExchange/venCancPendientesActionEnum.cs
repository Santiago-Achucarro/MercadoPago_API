using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 2 de noviembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCancPendientesActionEnum
        {            public enum EnumvenCancPendientesAction
            {
                Guardar,Datos
            }
        public static string GetAccionvenCancPendientesAction(venCancPendientesActionEnum.EnumvenCancPendientesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCancPendientesActionEnum.EnumvenCancPendientesAction.Guardar: lRetorno = "venCancPendientesGuardar"; break;
                case venCancPendientesActionEnum.EnumvenCancPendientesAction.Datos: lRetorno = "venCancPendientesDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
