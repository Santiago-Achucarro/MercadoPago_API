using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 28 de agosto de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange
{
    public static class comEmbCuerpoActionEnum
    {
        public enum EnumcomEmbCuerpoAction
        {
            Guardar, Eliminar, Datos, Recibir, Facturar
        }
        public static string GetAccioncomEmbCuerpoAction(comEmbCuerpoActionEnum.EnumcomEmbCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comEmbCuerpoActionEnum.EnumcomEmbCuerpoAction.Guardar: lRetorno = "comEmbCuerpoGuardar"; break;
                case comEmbCuerpoActionEnum.EnumcomEmbCuerpoAction.Eliminar: lRetorno = "comEmbCuerpoEliminar"; break;
                case comEmbCuerpoActionEnum.EnumcomEmbCuerpoAction.Datos: lRetorno = "comEmbCuerpoDevolverDatos"; break;
                case comEmbCuerpoActionEnum.EnumcomEmbCuerpoAction.Recibir: lRetorno = "comEmbCuerpoRecibir"; break;
                case comEmbCuerpoActionEnum.EnumcomEmbCuerpoAction.Facturar: lRetorno = "comEmbCuerpoFacturar"; break;
            }
            return lRetorno;
        }
    }
}
