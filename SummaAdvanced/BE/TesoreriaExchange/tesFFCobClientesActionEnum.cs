using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 21 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesFFCobClientesActionEnum
        {            public enum EnumtesFFCobClientesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesFFCobClientesAction(tesFFCobClientesActionEnum.EnumtesFFCobClientesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesFFCobClientesActionEnum.EnumtesFFCobClientesAction.Guardar: lRetorno = "tesFFCobClientesGuardar"; break;
                case tesFFCobClientesActionEnum.EnumtesFFCobClientesAction.Datos: lRetorno = "tesFFCobClientesDevolverDatos"; break;
                case tesFFCobClientesActionEnum.EnumtesFFCobClientesAction.Eliminar: lRetorno = "tesFFCobClientesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
