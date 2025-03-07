using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 26 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comReqInternoPendAutoActionEnum
        {            public enum EnumcomReqInternoPendAutoAction
            {
                Guardar,Datos
            }
        public static string GetAccioncomReqInternoPendAutoAction(comReqInternoPendAutoActionEnum.EnumcomReqInternoPendAutoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comReqInternoPendAutoActionEnum.EnumcomReqInternoPendAutoAction.Guardar: lRetorno = "comReqInternoPendAutoGuardar"; break;
                case comReqInternoPendAutoActionEnum.EnumcomReqInternoPendAutoAction.Datos: lRetorno = "comReqInternoPendAutoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
