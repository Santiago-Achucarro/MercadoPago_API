using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 27 de abril de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proOrdenSubRecursoActionEnum
        {            public enum EnumproOrdenSubRecursoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproOrdenSubRecursoAction(proOrdenSubRecursoActionEnum.EnumproOrdenSubRecursoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proOrdenSubRecursoActionEnum.EnumproOrdenSubRecursoAction.Guardar: lRetorno = "proOrdenSubRecursoGuardar"; break;
                case proOrdenSubRecursoActionEnum.EnumproOrdenSubRecursoAction.Datos: lRetorno = "proOrdenSubRecursoDevolverDatos"; break;
                case proOrdenSubRecursoActionEnum.EnumproOrdenSubRecursoAction.Eliminar: lRetorno = "proOrdenSubRecursoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
