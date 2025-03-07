using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 31 de diciembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genSaldoAnticipoActionEnum
        {            public enum EnumgenSaldoAnticipoAction
            {
                Datos
            }
        public static string GetAcciongenSaldoAnticipoAction(genSaldoAnticipoActionEnum.EnumgenSaldoAnticipoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genSaldoAnticipoActionEnum.EnumgenSaldoAnticipoAction.Datos: lRetorno = "genSaldoAnticipoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
