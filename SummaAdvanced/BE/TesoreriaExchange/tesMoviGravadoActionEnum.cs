using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de diciembre de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesMoviGravadoActionEnum
        {            public enum EnumtesMoviGravadoAction
            {
                Guardar,Eliminar
            }
        public static string GetAcciontesMoviGravadoAction(tesMoviGravadoActionEnum.EnumtesMoviGravadoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesMoviGravadoActionEnum.EnumtesMoviGravadoAction.Guardar: lRetorno = "tesMoviGravadoGuardar"; break;
                case tesMoviGravadoActionEnum.EnumtesMoviGravadoAction.Eliminar: lRetorno = "tesMoviGravadoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
