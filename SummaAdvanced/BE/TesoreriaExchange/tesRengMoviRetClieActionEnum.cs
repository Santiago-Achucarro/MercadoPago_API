using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 21 de diciembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesRengMoviRetClieActionEnum
        {            public enum EnumtesRengMoviRetClieAction
            {
                Guardar,Eliminar
            }
        public static string GetAcciontesRengMoviRetClieAction(tesRengMoviRetClieActionEnum.EnumtesRengMoviRetClieAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesRengMoviRetClieActionEnum.EnumtesRengMoviRetClieAction.Guardar: lRetorno = "tesRengMoviRetClieGuardar"; break;
                case tesRengMoviRetClieActionEnum.EnumtesRengMoviRetClieAction.Eliminar: lRetorno = "tesRengMoviRetClieEliminar"; break;
            }
            return lRetorno;
        }
    }
}
