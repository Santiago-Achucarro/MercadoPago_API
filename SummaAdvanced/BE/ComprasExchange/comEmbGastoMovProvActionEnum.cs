using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 16 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comEmbGastoMovProvActionEnum
        {            public enum EnumcomEmbGastoMovProvAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomEmbGastoMovProvAction(comEmbGastoMovProvActionEnum.EnumcomEmbGastoMovProvAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comEmbGastoMovProvActionEnum.EnumcomEmbGastoMovProvAction.Guardar: lRetorno = "comEmbGastoMovProvGuardar"; break;
                case comEmbGastoMovProvActionEnum.EnumcomEmbGastoMovProvAction.Datos: lRetorno = "comEmbGastoMovProvDevolverDatos"; break;
                case comEmbGastoMovProvActionEnum.EnumcomEmbGastoMovProvAction.Eliminar: lRetorno = "comEmbGastoMovProvEliminar"; break;
            }
            return lRetorno;
        }
    }
}
