using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI sábado, 28 de mayo de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genUsuariosActionEnum
        {            public enum EnumgenUsuariosAction
            {
                Guardar,Datos,Eliminar,DatosIdentity,Desbloquear,ActualizarEmail
            }
        public static string GetAcciongenUsuariosAction(genUsuariosActionEnum.EnumgenUsuariosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genUsuariosActionEnum.EnumgenUsuariosAction.Guardar: lRetorno = "genUsuariosGuardar"; break;
                case genUsuariosActionEnum.EnumgenUsuariosAction.Datos: lRetorno = "genUsuariosDevolverDatos"; break;
                case genUsuariosActionEnum.EnumgenUsuariosAction.Eliminar: lRetorno = "genUsuariosEliminar"; break;
                case genUsuariosActionEnum.EnumgenUsuariosAction.DatosIdentity: lRetorno = "genUsuariosDevolverDatosIdentity"; break;
                case genUsuariosActionEnum.EnumgenUsuariosAction.Desbloquear: lRetorno = "genUsuariosDesbloquear"; break;
                case genUsuariosActionEnum.EnumgenUsuariosAction.ActualizarEmail:lRetorno = "genUsuariosActualizarCorreo"; break;
                    
            }
            return lRetorno;
        }
    }
}
