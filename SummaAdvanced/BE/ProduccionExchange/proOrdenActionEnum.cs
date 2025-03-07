using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 20 de marzo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proOrdenActionEnum
        {            public enum EnumproOrdenAction
            {
                Guardar,Datos,Eliminar,Receta
            }
        public static string GetAccionproOrdenAction(proOrdenActionEnum.EnumproOrdenAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proOrdenActionEnum.EnumproOrdenAction.Guardar: lRetorno = "proOrdenGuardar"; break;
                case proOrdenActionEnum.EnumproOrdenAction.Datos: lRetorno = "proOrdenDevolverDatos"; break;
                case proOrdenActionEnum.EnumproOrdenAction.Eliminar: lRetorno = "proOrdenEliminar"; break;
                case proOrdenActionEnum.EnumproOrdenAction.Receta: lRetorno = "proOrdenReceta"; break;
            }
            return lRetorno;
        }
    }
}
