using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 17 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesIdTarjetas3ActionEnum
        {            public enum EnumtesIdTarjetas3Action
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesIdTarjetas3Action(tesIdTarjetas3ActionEnum.EnumtesIdTarjetas3Action pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesIdTarjetas3ActionEnum.EnumtesIdTarjetas3Action.Guardar: lRetorno = "tesIdTarjetas3Guardar"; break;
                case tesIdTarjetas3ActionEnum.EnumtesIdTarjetas3Action.Datos: lRetorno = "tesIdTarjetas3DevolverDatos"; break;
                case tesIdTarjetas3ActionEnum.EnumtesIdTarjetas3Action.Eliminar: lRetorno = "tesIdTarjetas3Eliminar"; break;
            }
            return lRetorno;
        }
    }
}
