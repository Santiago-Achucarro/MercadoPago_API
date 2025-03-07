using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 6 de abril de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venAddendaMXActionEnum
        {            public enum EnumvenAddendaMXAction
            {
                Generar
            }
        public static string GetAccionvenAddendaMXAction(venAddendaMXActionEnum.EnumvenAddendaMXAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venAddendaMXActionEnum.EnumvenAddendaMXAction.Generar: lRetorno = "venAddendaMXGenerar"; break;
            }
            return lRetorno;
        }
    }
}
