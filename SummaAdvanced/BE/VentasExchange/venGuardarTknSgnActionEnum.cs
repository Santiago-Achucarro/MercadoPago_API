using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 19 de julio de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venGuardarTknSgnActionEnum
        {            public enum EnumvenGuardarTknSgnAction
            {
                Guardar
            }
        public static string GetAccionvenGuardarTknSgnAction(venGuardarTknSgnActionEnum.EnumvenGuardarTknSgnAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venGuardarTknSgnActionEnum.EnumvenGuardarTknSgnAction.Guardar: lRetorno = "venGuardarTknSgnGuardar"; break;
            }
            return lRetorno;
        }
    }
}
