using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI domingo, 16 de diciembre de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genUltPaginasVisitadasUsuariosActionEnum
        {            public enum EnumgenUltPaginasVisitadasUsuariosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenUltPaginasVisitadasUsuariosAction(genUltPaginasVisitadasUsuariosActionEnum.EnumgenUltPaginasVisitadasUsuariosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genUltPaginasVisitadasUsuariosActionEnum.EnumgenUltPaginasVisitadasUsuariosAction.Guardar: lRetorno = "genUltPaginasVisitadasUsuariosGuardar"; break;
                case genUltPaginasVisitadasUsuariosActionEnum.EnumgenUltPaginasVisitadasUsuariosAction.Datos: lRetorno = "genUltPaginasVisitadasUsuariosDevolverDatos"; break;
                case genUltPaginasVisitadasUsuariosActionEnum.EnumgenUltPaginasVisitadasUsuariosAction.Eliminar: lRetorno = "genUltPaginasVisitadasUsuariosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
