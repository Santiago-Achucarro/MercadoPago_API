using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 25 de mayo de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genDiasFestivosFechaActionEnum
        {            public enum EnumgenDiasFestivosFechaAction
            {
                DatosFecha
            }
        public static string GetAcciongenDiasFestivosFechaAction(genDiasFestivosFechaActionEnum.EnumgenDiasFestivosFechaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genDiasFestivosFechaActionEnum.EnumgenDiasFestivosFechaAction.DatosFecha: lRetorno = "genDiasFestivosFechaDatosFecha"; break;
            }
            return lRetorno;
        }
    }
}
