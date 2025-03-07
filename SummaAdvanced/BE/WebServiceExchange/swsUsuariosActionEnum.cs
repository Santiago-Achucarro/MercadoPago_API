using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Monday, October 12, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace WebServiceExchange{
        public static class swsUsuariosActionEnum
        {            public enum EnumswsUsuariosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionswsUsuariosAction(swsUsuariosActionEnum.EnumswsUsuariosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case swsUsuariosActionEnum.EnumswsUsuariosAction.Guardar: lRetorno = "swsUsuariosGuardar"; break;
                case swsUsuariosActionEnum.EnumswsUsuariosAction.Datos: lRetorno = "swsUsuariosDevolverDatos"; break;
                case swsUsuariosActionEnum.EnumswsUsuariosAction.Eliminar: lRetorno = "swsUsuariosEliminar"; break;
                
            }
            return lRetorno;
        }
    }
}
