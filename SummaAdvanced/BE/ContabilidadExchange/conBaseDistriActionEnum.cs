using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 6 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conBaseDistriActionEnum
        {            public enum EnumconBaseDistriAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconBaseDistriAction(conBaseDistriActionEnum.EnumconBaseDistriAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conBaseDistriActionEnum.EnumconBaseDistriAction.Guardar: lRetorno = "conBaseDistriGuardar"; break;
                case conBaseDistriActionEnum.EnumconBaseDistriAction.Datos: lRetorno = "conBaseDistriDevolverDatos"; break;
                case conBaseDistriActionEnum.EnumconBaseDistriAction.Eliminar: lRetorno = "conBaseDistriEliminar"; break;
            }
            return lRetorno;
        }
    }
}
