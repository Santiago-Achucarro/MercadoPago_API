using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 11 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proMovCierreTrabajos3ActionEnum
        {            public enum EnumproMovCierreTrabajos3Action
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproMovCierreTrabajos3Action(proMovCierreTrabajos3ActionEnum.EnumproMovCierreTrabajos3Action pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proMovCierreTrabajos3ActionEnum.EnumproMovCierreTrabajos3Action.Guardar: lRetorno = "proMovCierreTrabajos3Guardar"; break;
                case proMovCierreTrabajos3ActionEnum.EnumproMovCierreTrabajos3Action.Datos: lRetorno = "proMovCierreTrabajos3DevolverDatos"; break;
                case proMovCierreTrabajos3ActionEnum.EnumproMovCierreTrabajos3Action.Eliminar: lRetorno = "proMovCierreTrabajos3Eliminar"; break;
            }
            return lRetorno;
        }
    }
}
