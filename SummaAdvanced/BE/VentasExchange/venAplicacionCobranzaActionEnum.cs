using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 9 de abril de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venAplicacionCobranzaActionEnum
        {            public enum EnumvenAplicacionCobranzaAction
            {
                Guardar,Datos
            }
        public static string GetAccionvenAplicacionCobranzaAction(venAplicacionCobranzaActionEnum.EnumvenAplicacionCobranzaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venAplicacionCobranzaActionEnum.EnumvenAplicacionCobranzaAction.Guardar: lRetorno = "venAplicacionCobranzaGuardar"; break;
                case venAplicacionCobranzaActionEnum.EnumvenAplicacionCobranzaAction.Datos: lRetorno = "venAplicacionCobranzaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
