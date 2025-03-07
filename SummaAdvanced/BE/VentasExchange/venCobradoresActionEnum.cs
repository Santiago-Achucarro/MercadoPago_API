using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venCobradoresActionEnum
        {            public enum EnumvenCobradoresAction
            {
                Guardar,Datos,DatosId,Eliminar
            }
        public static string GetAccionvenCobradoresAction(venCobradoresActionEnum.EnumvenCobradoresAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venCobradoresActionEnum.EnumvenCobradoresAction.Guardar: lRetorno = "venCobradoresGuardar"; break;
                case venCobradoresActionEnum.EnumvenCobradoresAction.Datos: lRetorno = "venCobradoresDevolverDatos"; break;
                case venCobradoresActionEnum.EnumvenCobradoresAction.DatosId: lRetorno = "venCobradoresDatosId"; break;
                case venCobradoresActionEnum.EnumvenCobradoresAction.Eliminar: lRetorno = "venCobradoresEliminar"; break;
            }
            return lRetorno;
        }
    }
}
