using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Tuesday, May 5, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genDiasFestivosActionEnum
        {            public enum EnumgenDiasFestivosAction
            {
                Guardar,Datos
            }
        public static string GetAcciongenDiasFestivosAction(genDiasFestivosActionEnum.EnumgenDiasFestivosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genDiasFestivosActionEnum.EnumgenDiasFestivosAction.Guardar: lRetorno = "genDiasFestivosGuardar"; break;
                case genDiasFestivosActionEnum.EnumgenDiasFestivosAction.Datos: lRetorno = "genDiasFestivosDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
