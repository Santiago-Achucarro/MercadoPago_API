using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 7 de enero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesIdentificaSaldoActionEnum
        {            public enum EnumtesIdentificaSaldoAction
            {
                Datos
            }
        public static string GetAcciontesIdentificaSaldoAction(tesIdentificaSaldoActionEnum.EnumtesIdentificaSaldoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesIdentificaSaldoActionEnum.EnumtesIdentificaSaldoAction.Datos: lRetorno = "tesIdentificaSaldoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
