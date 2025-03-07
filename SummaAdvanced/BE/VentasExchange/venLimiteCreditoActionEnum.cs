using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 26 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venLimiteCreditoActionEnum
        {            public enum EnumvenLimiteCreditoAction
            {
                Guardar,Datos
            }
        public static string GetAccionvenLimiteCreditoAction(venLimiteCreditoActionEnum.EnumvenLimiteCreditoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venLimiteCreditoActionEnum.EnumvenLimiteCreditoAction.Guardar: lRetorno = "venLimiteCreditoGuardar"; break;
                case venLimiteCreditoActionEnum.EnumvenLimiteCreditoAction.Datos: lRetorno = "venLimiteCreditoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
