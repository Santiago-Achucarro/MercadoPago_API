using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 17 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesIdTarjetasTipoActionEnum
        {            public enum EnumtesIdTarjetasTipoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesIdTarjetasTipoAction(tesIdTarjetasTipoActionEnum.EnumtesIdTarjetasTipoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesIdTarjetasTipoActionEnum.EnumtesIdTarjetasTipoAction.Guardar: lRetorno = "tesIdTarjetasTipoGuardar"; break;
                case tesIdTarjetasTipoActionEnum.EnumtesIdTarjetasTipoAction.Datos: lRetorno = "tesIdTarjetasTipoDevolverDatos"; break;
                case tesIdTarjetasTipoActionEnum.EnumtesIdTarjetasTipoAction.Eliminar: lRetorno = "tesIdTarjetasTipoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
