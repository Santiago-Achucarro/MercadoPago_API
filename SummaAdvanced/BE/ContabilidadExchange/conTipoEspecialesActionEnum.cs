using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI jueves, 16 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conTipoEspecialesActionEnum
        {            public enum EnumconTipoEspecialesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconTipoEspecialesAction(conTipoEspecialesActionEnum.EnumconTipoEspecialesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conTipoEspecialesActionEnum.EnumconTipoEspecialesAction.Guardar: lRetorno = "conTipoEspecialesGuardar"; break;
                case conTipoEspecialesActionEnum.EnumconTipoEspecialesAction.Datos: lRetorno = "conTipoEspecialesDevolverDatos"; break;
                case conTipoEspecialesActionEnum.EnumconTipoEspecialesAction.Eliminar: lRetorno = "conTipoEspecialesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
