using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 26 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesRengConciliacActionEnum
        {            public enum EnumtesRengConciliacAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesRengConciliacAction(tesRengConciliacActionEnum.EnumtesRengConciliacAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesRengConciliacActionEnum.EnumtesRengConciliacAction.Guardar: lRetorno = "tesRengConciliacGuardar"; break;
                case tesRengConciliacActionEnum.EnumtesRengConciliacAction.Datos: lRetorno = "tesRengConciliacDevolverDatos"; break;
                case tesRengConciliacActionEnum.EnumtesRengConciliacAction.Eliminar: lRetorno = "tesRengConciliacEliminar"; break;
            }
            return lRetorno;
        }
    }
}
