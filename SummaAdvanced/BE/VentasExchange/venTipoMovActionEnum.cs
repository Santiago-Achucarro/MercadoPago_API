using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venTipoMovActionEnum
        {            public enum EnumvenTipoMovAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenTipoMovAction(venTipoMovActionEnum.EnumvenTipoMovAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venTipoMovActionEnum.EnumvenTipoMovAction.Guardar: lRetorno = "venTipoMovGuardar"; break;
                case venTipoMovActionEnum.EnumvenTipoMovAction.Datos: lRetorno = "venTipoMovDevolverDatos"; break;
                case venTipoMovActionEnum.EnumvenTipoMovAction.Eliminar: lRetorno = "venTipoMovEliminar"; break;
            }
            return lRetorno;
        }
    }
}
