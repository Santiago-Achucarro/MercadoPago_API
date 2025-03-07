using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 5 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venTraePendientesActionEnum
        {            public enum EnumvenTraePendientesAction
            {
                Datos
            }
        public static string GetAccionvenTraePendientesAction(venTraePendientesActionEnum.EnumvenTraePendientesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venTraePendientesActionEnum.EnumvenTraePendientesAction.Datos: lRetorno = "venTraePendientesDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
