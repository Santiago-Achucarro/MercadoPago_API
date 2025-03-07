using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 1 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proProgramaOrdenActionEnum
        {            public enum EnumproProgramaOrdenAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproProgramaOrdenAction(proProgramaOrdenActionEnum.EnumproProgramaOrdenAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proProgramaOrdenActionEnum.EnumproProgramaOrdenAction.Guardar: lRetorno = "proProgramaOrdenGuardar"; break;
                case proProgramaOrdenActionEnum.EnumproProgramaOrdenAction.Datos: lRetorno = "proProgramaOrdenDevolverDatos"; break;
                case proProgramaOrdenActionEnum.EnumproProgramaOrdenAction.Eliminar: lRetorno = "proProgramaOrdenEliminar"; break;
            }
            return lRetorno;
        }
    }
}
