using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 14 de julio de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genUsuariosSucursalActionEnum
        {            public enum EnumgenUsuariosSucursalAction
            {
                Datos,Eliminar,Insertar
            }
        public static string GetAcciongenUsuariosSucursalAction(genUsuariosSucursalActionEnum.EnumgenUsuariosSucursalAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genUsuariosSucursalActionEnum.EnumgenUsuariosSucursalAction.Datos: lRetorno = "genUsuariosSucursalDevolverDatos"; break;
                case genUsuariosSucursalActionEnum.EnumgenUsuariosSucursalAction.Eliminar: lRetorno = "genUsuariosSucursalEliminar"; break;
                case genUsuariosSucursalActionEnum.EnumgenUsuariosSucursalAction.Insertar: lRetorno = "genUsuariosSucursalInsertar"; break;
            }
            return lRetorno;
        }
    }
}
