using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 15 de septiembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class XmlComprobanteActionEnum
        {            public enum EnumXmlComprobanteAction
            {
                Datos
            }
        public static string GetAccionXmlComprobanteAction(XmlComprobanteActionEnum.EnumXmlComprobanteAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case XmlComprobanteActionEnum.EnumXmlComprobanteAction.Datos: lRetorno = "XmlComprobanteDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
