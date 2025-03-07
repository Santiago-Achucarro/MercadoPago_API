using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 2 de abril de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvXmlActionEnum
        {            public enum EnumcomMovProvXmlAction
            {
                Guardar,Datos,Buscar, Xml
            }
        public static string GetAccioncomMovProvXmlAction(comMovProvXmlActionEnum.EnumcomMovProvXmlAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvXmlActionEnum.EnumcomMovProvXmlAction.Guardar: lRetorno = "comMovProvXmlGuardar"; break;
                case comMovProvXmlActionEnum.EnumcomMovProvXmlAction.Datos: lRetorno = "comMovProvXmlDevolverDatos"; break;
                case comMovProvXmlActionEnum.EnumcomMovProvXmlAction.Buscar: lRetorno = "comMovProvXmlBuscar"; break;
                case comMovProvXmlActionEnum.EnumcomMovProvXmlAction.Xml: lRetorno = "comMovProvXmlXml"; break;
            }
            return lRetorno;
        }
    }
}
