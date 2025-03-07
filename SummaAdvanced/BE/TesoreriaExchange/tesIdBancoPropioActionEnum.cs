using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, July 1, 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesIdBancoPropioActionEnum
        {            public enum EnumtesIdBancoPropioAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesIdBancoPropioAction(tesIdBancoPropioActionEnum.EnumtesIdBancoPropioAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesIdBancoPropioActionEnum.EnumtesIdBancoPropioAction.Guardar: lRetorno = "tesIdBancoPropioGuardar"; break;
                case tesIdBancoPropioActionEnum.EnumtesIdBancoPropioAction.Datos: lRetorno = "tesIdBancoPropioDevolverDatos"; break;
                case tesIdBancoPropioActionEnum.EnumtesIdBancoPropioAction.Eliminar: lRetorno = "tesIdBancoPropioEliminar"; break;
            }
            return lRetorno;
        }
    }
}
