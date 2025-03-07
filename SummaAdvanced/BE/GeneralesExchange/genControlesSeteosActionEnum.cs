using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 20 de septiembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genControlesSeteosActionEnum
        {            public enum EnumgenControlesSeteosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenControlesSeteosAction(genControlesSeteosActionEnum.EnumgenControlesSeteosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genControlesSeteosActionEnum.EnumgenControlesSeteosAction.Guardar: lRetorno = "genControlesSeteosGuardar"; break;
                case genControlesSeteosActionEnum.EnumgenControlesSeteosAction.Datos: lRetorno = "genControlesSeteosDevolverDatos"; break;
                case genControlesSeteosActionEnum.EnumgenControlesSeteosAction.Eliminar: lRetorno = "genControlesSeteosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
