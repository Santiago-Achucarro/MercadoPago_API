using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 15 de septiembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesDepIdentificacionActionEnum
        {            public enum EnumtesDepIdentificacionAction
            {
                Guardar,Datos
            }
        public static string GetAcciontesDepIdentificacionAction(tesDepIdentificacionActionEnum.EnumtesDepIdentificacionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesDepIdentificacionActionEnum.EnumtesDepIdentificacionAction.Guardar: lRetorno = "tesDepIdentificacionGuardar"; break;
                case tesDepIdentificacionActionEnum.EnumtesDepIdentificacionAction.Datos: lRetorno = "tesDepIdentificacionDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
