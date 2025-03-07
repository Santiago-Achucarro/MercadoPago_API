using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 26 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesRengMoviActionEnum
        {            public enum EnumtesRengMoviAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesRengMoviAction(tesRengMoviActionEnum.EnumtesRengMoviAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesRengMoviActionEnum.EnumtesRengMoviAction.Guardar: lRetorno = "tesRengMoviGuardar"; break;
                case tesRengMoviActionEnum.EnumtesRengMoviAction.Datos: lRetorno = "tesRengMoviDevolverDatos"; break;
                case tesRengMoviActionEnum.EnumtesRengMoviAction.Eliminar: lRetorno = "tesRengMoviEliminar"; break;
            }
            return lRetorno;
        }
    }
}
