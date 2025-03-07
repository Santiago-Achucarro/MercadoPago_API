using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 21 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conAnexosOrigenesActionEnum
        {            public enum EnumconAnexosOrigenesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconAnexosOrigenesAction(conAnexosOrigenesActionEnum.EnumconAnexosOrigenesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conAnexosOrigenesActionEnum.EnumconAnexosOrigenesAction.Guardar: lRetorno = "conAnexosOrigenesGuardar"; break;
                case conAnexosOrigenesActionEnum.EnumconAnexosOrigenesAction.Datos: lRetorno = "conAnexosOrigenesDevolverDatos"; break;
                case conAnexosOrigenesActionEnum.EnumconAnexosOrigenesAction.Eliminar: lRetorno = "conAnexosOrigenesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
