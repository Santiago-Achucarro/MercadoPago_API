using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 24 de enero de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comReqInternoCompTienePendEntregaActionEnum
        {            public enum EnumcomReqInternoCompTienePendEntregaAction
            {
                Datos
            }
        public static string GetAccioncomReqInternoCompTienePendEntregaAction(comReqInternoCompTienePendEntregaActionEnum.EnumcomReqInternoCompTienePendEntregaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comReqInternoCompTienePendEntregaActionEnum.EnumcomReqInternoCompTienePendEntregaAction.Datos: lRetorno = "comReqInternoCompTienePendEntregaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
