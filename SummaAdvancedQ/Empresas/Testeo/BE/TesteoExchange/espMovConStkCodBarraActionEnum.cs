using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 28 de septiembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesteoExchange{
        public static class espMovConStkCodBarraActionEnum
        {            public enum EnumespMovConStkCodBarraAction
            {
                LlenarGrilla
            }
        public static string GetAccionespMovConStkCodBarraAction(espMovConStkCodBarraActionEnum.EnumespMovConStkCodBarraAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espMovConStkCodBarraActionEnum.EnumespMovConStkCodBarraAction.LlenarGrilla: lRetorno = "espMovConStkCodBarraLlenarGrilla"; break;
            }
            return lRetorno;
        }
    }
}
