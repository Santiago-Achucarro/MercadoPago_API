using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 30 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueVacTomadasActionEnum
        {            public enum EnumsueVacTomadasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueVacTomadasAction(sueVacTomadasActionEnum.EnumsueVacTomadasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueVacTomadasActionEnum.EnumsueVacTomadasAction.Guardar: lRetorno = "sueVacTomadasGuardar"; break;
                case sueVacTomadasActionEnum.EnumsueVacTomadasAction.Datos: lRetorno = "sueVacTomadasDevolverDatos"; break;
                case sueVacTomadasActionEnum.EnumsueVacTomadasAction.Eliminar: lRetorno = "sueVacTomadasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
