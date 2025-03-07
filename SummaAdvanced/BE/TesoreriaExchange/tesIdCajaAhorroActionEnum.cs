using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 19 de agosto de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesIdCajaAhorroActionEnum
        {            public enum EnumtesIdCajaAhorroAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesIdCajaAhorroAction(tesIdCajaAhorroActionEnum.EnumtesIdCajaAhorroAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesIdCajaAhorroActionEnum.EnumtesIdCajaAhorroAction.Guardar: lRetorno = "tesIdCajaAhorroGuardar"; break;
                case tesIdCajaAhorroActionEnum.EnumtesIdCajaAhorroAction.Datos: lRetorno = "tesIdCajaAhorroDevolverDatos"; break;
                case tesIdCajaAhorroActionEnum.EnumtesIdCajaAhorroAction.Eliminar: lRetorno = "tesIdCajaAhorroEliminar"; break;
            }
            return lRetorno;
        }
    }
}
