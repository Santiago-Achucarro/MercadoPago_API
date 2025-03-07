using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 2 de abril de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovprovXmlBuscarActionEnum
        {            public enum EnumcomMovprovXmlBuscarAction
            {
                Datos
            }
        public static string GetAccioncomMovprovXmlBuscarAction(comMovprovXmlBuscarActionEnum.EnumcomMovprovXmlBuscarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovprovXmlBuscarActionEnum.EnumcomMovprovXmlBuscarAction.Datos: lRetorno = "comMovprovXmlBuscarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
