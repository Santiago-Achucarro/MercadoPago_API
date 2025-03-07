using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 28 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comEmbGastosActionEnum
        {            public enum EnumcomEmbGastosAction
            {
                Guardar,Eliminar
            }
        public static string GetAccioncomEmbGastosAction(comEmbGastosActionEnum.EnumcomEmbGastosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comEmbGastosActionEnum.EnumcomEmbGastosAction.Guardar: lRetorno = "comEmbGastosGuardar"; break;
                case comEmbGastosActionEnum.EnumcomEmbGastosAction.Eliminar: lRetorno = "comEmbGastosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
