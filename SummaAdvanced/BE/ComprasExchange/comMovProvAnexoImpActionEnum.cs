using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de septiembre de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ComprasExchange{
        public static class comMovProvAnexoImpActionEnum
        {            public enum EnumcomMovProvAnexoImpAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccioncomMovProvAnexoImpAction(comMovProvAnexoImpActionEnum.EnumcomMovProvAnexoImpAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case comMovProvAnexoImpActionEnum.EnumcomMovProvAnexoImpAction.Guardar: lRetorno = "comMovProvAnexoImpGuardar"; break;
                case comMovProvAnexoImpActionEnum.EnumcomMovProvAnexoImpAction.Datos: lRetorno = "comMovProvAnexoImpDevolverDatos"; break;
                case comMovProvAnexoImpActionEnum.EnumcomMovProvAnexoImpAction.Eliminar: lRetorno = "comMovProvAnexoImpEliminar"; break;
            }
            return lRetorno;
        }
    }
}
