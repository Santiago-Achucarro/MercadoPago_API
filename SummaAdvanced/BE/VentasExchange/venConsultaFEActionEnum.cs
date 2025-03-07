using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 19 de julio de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venConsultaFEActionEnum
        {            public enum EnumvenConsultaFEAction
            {
                Datos
            }
        public static string GetAccionvenConsultaFEAction(venConsultaFEActionEnum.EnumvenConsultaFEAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venConsultaFEActionEnum.EnumvenConsultaFEAction.Datos: lRetorno = "venConsultaFEDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
