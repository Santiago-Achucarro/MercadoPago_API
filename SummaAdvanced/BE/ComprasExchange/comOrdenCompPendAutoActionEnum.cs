using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, October 18, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comOrdenCompPendAutoActionEnum
        {            public enum EnumcomOrdenCompPendAutoAction
            {
                Guardar,Datos,Enviar
            }
        public static string GetAccioncomOrdenCompPendAutoAction(comOrdenCompPendAutoActionEnum.EnumcomOrdenCompPendAutoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOrdenCompPendAutoActionEnum.EnumcomOrdenCompPendAutoAction.Guardar: lRetorno = "comOrdenCompPendAutoGuardar"; break;
                case comOrdenCompPendAutoActionEnum.EnumcomOrdenCompPendAutoAction.Datos: lRetorno = "comOrdenCompPendAutoDevolverDatos"; break;
                case comOrdenCompPendAutoActionEnum.EnumcomOrdenCompPendAutoAction.Enviar: lRetorno = "comOrdenCompPendAutoEnviar"; break;
            }
            return lRetorno;
        }
    }
}
