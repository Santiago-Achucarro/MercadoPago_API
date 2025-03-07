using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 29 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venSubTipoMovActionEnum
        {            public enum EnumvenSubTipoMovAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenSubTipoMovAction(venSubTipoMovActionEnum.EnumvenSubTipoMovAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Guardar: lRetorno = "venSubTipoMovGuardar"; break;
                case venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos: lRetorno = "venSubTipoMovDevolverDatos"; break;
                case venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Eliminar: lRetorno = "venSubTipoMovEliminar"; break;
            }
            return lRetorno;
        }
    }
}
