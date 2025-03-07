using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 18 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proCausasActionEnum
        {            public enum EnumproCausasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionproCausasAction(proCausasActionEnum.EnumproCausasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proCausasActionEnum.EnumproCausasAction.Guardar: lRetorno = "proCausasGuardar"; break;
                case proCausasActionEnum.EnumproCausasAction.Datos: lRetorno = "proCausasDevolverDatos"; break;
                case proCausasActionEnum.EnumproCausasAction.Eliminar: lRetorno = "proCausasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
