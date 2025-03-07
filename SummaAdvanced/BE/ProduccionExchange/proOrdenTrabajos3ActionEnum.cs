using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 20 de marzo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proOrdenTrabajos3ActionEnum
        {            public enum EnumproOrdenTrabajos3Action
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproOrdenTrabajos3Action(proOrdenTrabajos3ActionEnum.EnumproOrdenTrabajos3Action pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proOrdenTrabajos3ActionEnum.EnumproOrdenTrabajos3Action.Guardar: lRetorno = "proOrdenTrabajos3Guardar"; break;
                case proOrdenTrabajos3ActionEnum.EnumproOrdenTrabajos3Action.Datos: lRetorno = "proOrdenTrabajos3DevolverDatos"; break;
                case proOrdenTrabajos3ActionEnum.EnumproOrdenTrabajos3Action.Eliminar: lRetorno = "proOrdenTrabajos3Eliminar"; break;
            }
            return lRetorno;
        }
    }
}
