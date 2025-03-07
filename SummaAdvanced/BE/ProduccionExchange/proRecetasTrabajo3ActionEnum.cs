using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 22 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proRecetasTrabajo3ActionEnum
        {            public enum EnumproRecetasTrabajo3Action
            {
                Guardar,Eliminar
            }
        public static string GetAccionproRecetasTrabajo3Action(proRecetasTrabajo3ActionEnum.EnumproRecetasTrabajo3Action pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proRecetasTrabajo3ActionEnum.EnumproRecetasTrabajo3Action.Guardar: lRetorno = "proRecetasTrabajo3Guardar"; break;
                case proRecetasTrabajo3ActionEnum.EnumproRecetasTrabajo3Action.Eliminar: lRetorno = "proRecetasTrabajo3Eliminar"; break;
            }
            return lRetorno;
        }
    }
}
