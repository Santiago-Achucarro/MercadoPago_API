using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 6 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesMovimientosEnviarActionEnum
        {            public enum EnumtesMovimientosEnviarAction
            {
                Datos
            }
        public static string GetAcciontesMovimientosEnviarAction(tesMovimientosEnviarActionEnum.EnumtesMovimientosEnviarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesMovimientosEnviarActionEnum.EnumtesMovimientosEnviarAction.Datos: lRetorno = "tesMovimientosEnviarDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
