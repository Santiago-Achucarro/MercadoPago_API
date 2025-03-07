using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 28 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venMoviAnticipoActionEnum
        {            public enum EnumvenMoviAnticipoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionvenMoviAnticipoAction(venMoviAnticipoActionEnum.EnumvenMoviAnticipoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venMoviAnticipoActionEnum.EnumvenMoviAnticipoAction.Guardar: lRetorno = "venMoviAnticipoGuardar"; break;
                case venMoviAnticipoActionEnum.EnumvenMoviAnticipoAction.Datos: lRetorno = "venMoviAnticipoDevolverDatos"; break;
                case venMoviAnticipoActionEnum.EnumvenMoviAnticipoAction.Eliminar: lRetorno = "venMoviAnticipoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
