using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 5 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venRepaPediSerieActionEnum
        {            public enum EnumvenRepaPediSerieAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenRepaPediSerieAction(venRepaPediSerieActionEnum.EnumvenRepaPediSerieAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venRepaPediSerieActionEnum.EnumvenRepaPediSerieAction.Guardar: lRetorno = "venRepaPediSerieGuardar"; break;
                case venRepaPediSerieActionEnum.EnumvenRepaPediSerieAction.Datos: lRetorno = "venRepaPediSerieDevolverDatos"; break;
                case venRepaPediSerieActionEnum.EnumvenRepaPediSerieAction.Eliminar: lRetorno = "venRepaPediSerieEliminar"; break;
            }
            return lRetorno;
        }
    }
}
