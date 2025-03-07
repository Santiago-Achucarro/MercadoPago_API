using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 17 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venIncotermActionEnum
        {            public enum EnumvenIncotermAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenIncotermAction(venIncotermActionEnum.EnumvenIncotermAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venIncotermActionEnum.EnumvenIncotermAction.Guardar: lRetorno = "venIncotermGuardar"; break;
                case venIncotermActionEnum.EnumvenIncotermAction.Datos: lRetorno = "venIncotermDevolverDatos"; break;
                case venIncotermActionEnum.EnumvenIncotermAction.Eliminar: lRetorno = "venIncotermEliminar"; break;
            }
            return lRetorno;
        }
    }
}
