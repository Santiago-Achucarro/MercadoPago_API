using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 6 de julio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMovAnuladosActionEnum
        {            public enum EnumvenMovAnuladosAction
            {
                Guardar,Datos,PDF
            }
        public static string GetAccionvenMovAnuladosAction(venMovAnuladosActionEnum.EnumvenMovAnuladosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMovAnuladosActionEnum.EnumvenMovAnuladosAction.Guardar: lRetorno = "venMovAnuladosGuardar"; break;
                case venMovAnuladosActionEnum.EnumvenMovAnuladosAction.Datos: lRetorno = "venMovAnuladosDevolverDatos"; break;
                case venMovAnuladosActionEnum.EnumvenMovAnuladosAction.PDF: lRetorno = "venMovAnuladosPDF"; break;
            }
            return lRetorno;
        }
    }
}
