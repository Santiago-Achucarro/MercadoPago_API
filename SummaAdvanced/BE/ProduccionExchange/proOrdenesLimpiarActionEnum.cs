using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 23 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proOrdenesLimpiarActionEnum
        {            public enum EnumproOrdenesLimpiarAction
            {
                Guardar,Datos,Todas,Ninguna
            }
        public static string GetAccionproOrdenesLimpiarAction(proOrdenesLimpiarActionEnum.EnumproOrdenesLimpiarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proOrdenesLimpiarActionEnum.EnumproOrdenesLimpiarAction.Guardar: lRetorno = "proOrdenesLimpiarGuardar"; break;
                case proOrdenesLimpiarActionEnum.EnumproOrdenesLimpiarAction.Datos: lRetorno = "proOrdenesLimpiarDevolverDatos"; break;
                case proOrdenesLimpiarActionEnum.EnumproOrdenesLimpiarAction.Todas: lRetorno = "proOrdenesLimpiarTodas"; break;
                case proOrdenesLimpiarActionEnum.EnumproOrdenesLimpiarAction.Ninguna: lRetorno = "proOrdenesLimpiarNinguna"; break;
            }
            return lRetorno;
        }
    }
}
