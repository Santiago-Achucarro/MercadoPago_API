using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proRecetasProdActionEnum
        {            public enum EnumproRecetasProdAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionproRecetasProdAction(proRecetasProdActionEnum.EnumproRecetasProdAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proRecetasProdActionEnum.EnumproRecetasProdAction.Guardar: lRetorno = "proRecetasProdGuardar"; break;
                case proRecetasProdActionEnum.EnumproRecetasProdAction.Eliminar: lRetorno = "proRecetasProdEliminar"; break;
            }
            return lRetorno;
        }
    }
}
