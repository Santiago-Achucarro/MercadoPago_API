using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 16 de marzo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvEmbActionEnum
        {            public enum EnumcomMovProvEmbAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomMovProvEmbAction(comMovProvEmbActionEnum.EnumcomMovProvEmbAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvEmbActionEnum.EnumcomMovProvEmbAction.Guardar: lRetorno = "comMovProvEmbGuardar"; break;
                case comMovProvEmbActionEnum.EnumcomMovProvEmbAction.Datos: lRetorno = "comMovProvEmbDevolverDatos"; break;
                case comMovProvEmbActionEnum.EnumcomMovProvEmbAction.Eliminar: lRetorno = "comMovProvEmbEliminar"; break;
            }
            return lRetorno;
        }
    }
}
