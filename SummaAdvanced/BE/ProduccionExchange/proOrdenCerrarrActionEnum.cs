using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 9 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proOrdenCerrarrActionEnum
        {            public enum EnumproOrdenCerrarrAction
            {
                Guardar,Datos,Eliminar, Calcular
            }
        public static string GetAccionproOrdenCerrarrAction(proOrdenCerrarrActionEnum.EnumproOrdenCerrarrAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proOrdenCerrarrActionEnum.EnumproOrdenCerrarrAction.Guardar: lRetorno = "proOrdenCerrarrGuardar"; break;
                case proOrdenCerrarrActionEnum.EnumproOrdenCerrarrAction.Datos: lRetorno = "proOrdenCerrarrDevolverDatos"; break;
                case proOrdenCerrarrActionEnum.EnumproOrdenCerrarrAction.Calcular: lRetorno = "proOrdenCerrarrCalcular"; break;
                case proOrdenCerrarrActionEnum.EnumproOrdenCerrarrAction.Eliminar: lRetorno = "proOrdenCerrarrEliminar"; break;
            }
            return lRetorno;
        }
    }
}
