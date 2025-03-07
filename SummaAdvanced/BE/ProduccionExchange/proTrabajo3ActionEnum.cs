using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proTrabajo3ActionEnum
        {            public enum EnumproTrabajo3Action
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproTrabajo3Action(proTrabajo3ActionEnum.EnumproTrabajo3Action pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proTrabajo3ActionEnum.EnumproTrabajo3Action.Guardar: lRetorno = "proTrabajo3Guardar"; break;
                case proTrabajo3ActionEnum.EnumproTrabajo3Action.Datos: lRetorno = "proTrabajo3DevolverDatos"; break;
                case proTrabajo3ActionEnum.EnumproTrabajo3Action.Eliminar: lRetorno = "proTrabajo3Eliminar"; break;
            }
            return lRetorno;
        }
    }
}
