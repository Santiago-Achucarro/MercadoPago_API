using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 16 de diciembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genFavoritosUsuariosActionEnum
        {            public enum EnumgenFavoritosUsuariosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenFavoritosUsuariosAction(genFavoritosUsuariosActionEnum.EnumgenFavoritosUsuariosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genFavoritosUsuariosActionEnum.EnumgenFavoritosUsuariosAction.Guardar: lRetorno = "genFavoritosUsuariosGuardar"; break;
                case genFavoritosUsuariosActionEnum.EnumgenFavoritosUsuariosAction.Datos: lRetorno = "genFavoritosUsuariosDevolverDatos"; break;
                case genFavoritosUsuariosActionEnum.EnumgenFavoritosUsuariosAction.Eliminar: lRetorno = "genFavoritosUsuariosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
