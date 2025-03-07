using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 9 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venIndicadoresActionEnum
        {            public enum EnumvenIndicadoresAction
            {
                Datos
            }
        public static string GetAccionvenIndicadoresAction(venIndicadoresActionEnum.EnumvenIndicadoresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venIndicadoresActionEnum.EnumvenIndicadoresAction.Datos: lRetorno = "venIndicadoresDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
