using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 28 de abril de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comOrdenCompTienePendEntregaActionEnum
        {            public enum EnumcomOrdenCompTienePendEntregaAction
            {
                TienePendEntrega
            }
        public static string GetAccioncomOrdenCompTienePendEntregaAction(comOrdenCompTienePendEntregaActionEnum.EnumcomOrdenCompTienePendEntregaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comOrdenCompTienePendEntregaActionEnum.EnumcomOrdenCompTienePendEntregaAction.TienePendEntrega: lRetorno = "comOrdenCompTienePendEntregaTienePendEntrega"; break;
            }
            return lRetorno;
        }
    }
}
