using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 26 de enero de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venListaCoeficienteActionEnum
        {            public enum EnumvenListaCoeficienteAction
            {
                Guardar
            }
        public static string GetAccionvenListaCoeficienteAction(venListaCoeficienteActionEnum.EnumvenListaCoeficienteAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venListaCoeficienteActionEnum.EnumvenListaCoeficienteAction.Guardar: lRetorno = "venListaCoeficienteGuardar"; break;
            }
            return lRetorno;
        }
    }
}
