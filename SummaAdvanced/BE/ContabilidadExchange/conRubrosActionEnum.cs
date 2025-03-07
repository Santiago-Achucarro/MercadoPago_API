using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 14 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conRubrosActionEnum
        {            public enum EnumconRubrosAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconRubrosAction(conRubrosActionEnum.EnumconRubrosAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conRubrosActionEnum.EnumconRubrosAction.Guardar: lRetorno = "conRubrosGuardar"; break;
                case conRubrosActionEnum.EnumconRubrosAction.Datos: lRetorno = "conRubrosDevolverDatos"; break;
                case conRubrosActionEnum.EnumconRubrosAction.Eliminar: lRetorno = "conRubrosEliminar"; break;
            }
            return lRetorno;
        }
    }
}
