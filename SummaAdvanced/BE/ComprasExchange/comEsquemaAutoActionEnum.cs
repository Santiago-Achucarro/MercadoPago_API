using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, September 6, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comEsquemaAutoActionEnum
        {            public enum EnumcomEsquemaAutoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomEsquemaAutoAction(comEsquemaAutoActionEnum.EnumcomEsquemaAutoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comEsquemaAutoActionEnum.EnumcomEsquemaAutoAction.Guardar: lRetorno = "comEsquemaAutoGuardar"; break;
                case comEsquemaAutoActionEnum.EnumcomEsquemaAutoAction.Datos: lRetorno = "comEsquemaAutoDevolverDatos"; break;
                case comEsquemaAutoActionEnum.EnumcomEsquemaAutoAction.Eliminar: lRetorno = "comEsquemaAutoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
