using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 7 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proPasarAProduccionActionEnum
        {            public enum EnumproPasarAProduccionAction
            {
                Guardar,Datos,Todas, Ninguna
            }
        public static string GetAccionproPasarAProduccionAction(proPasarAProduccionActionEnum.EnumproPasarAProduccionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proPasarAProduccionActionEnum.EnumproPasarAProduccionAction.Guardar: lRetorno = "proPasarAProduccionGuardar"; break;
                case proPasarAProduccionActionEnum.EnumproPasarAProduccionAction.Datos: lRetorno = "proPasarAProduccionDevolverDatos"; break;
                case proPasarAProduccionActionEnum.EnumproPasarAProduccionAction.Todas: lRetorno = "proPasarAProduccionTodas"; break;
                case proPasarAProduccionActionEnum.EnumproPasarAProduccionAction.Ninguna: lRetorno = "proPasarAProduccionNinguna"; break;
            }
            return lRetorno;
        }
    }
}
