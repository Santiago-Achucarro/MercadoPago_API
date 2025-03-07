using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 24 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venAsiCierreCalculoActionEnum
        {            public enum EnumvenAsiCierreCalculoAction
            {
                Datos
            }
        public static string GetAccionvenAsiCierreCalculoAction(venAsiCierreCalculoActionEnum.EnumvenAsiCierreCalculoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venAsiCierreCalculoActionEnum.EnumvenAsiCierreCalculoAction.Datos: lRetorno = "venAsiCierreCalculoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
