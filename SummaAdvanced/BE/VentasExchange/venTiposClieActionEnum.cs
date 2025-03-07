using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venTiposClieActionEnum
        {            public enum EnumvenTiposClieAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenTiposClieAction(venTiposClieActionEnum.EnumvenTiposClieAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venTiposClieActionEnum.EnumvenTiposClieAction.Guardar: lRetorno = "venTiposClieGuardar"; break;
                case venTiposClieActionEnum.EnumvenTiposClieAction.Datos: lRetorno = "venTiposClieDevolverDatos"; break;
                case venTiposClieActionEnum.EnumvenTiposClieAction.Eliminar: lRetorno = "venTiposClieEliminar"; break;
            }
            return lRetorno;
        }
    }
}
