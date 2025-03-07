using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, February 7, 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venClieHabitualActionEnum
        {            public enum EnumvenClieHabitualAction
            {
                Guardar,Datos,Eliminar,DatosSucursal,AdjuntosDatos, AsignarLocalidad
        }
        public static string GetAccionvenClieHabitualAction(venClieHabitualActionEnum.EnumvenClieHabitualAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venClieHabitualActionEnum.EnumvenClieHabitualAction.Guardar: lRetorno = "venClieHabitualGuardar"; break;
                case venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos: lRetorno = "venClieHabitualDevolverDatos"; break;
                case venClieHabitualActionEnum.EnumvenClieHabitualAction.Eliminar: lRetorno = "venClieHabitualEliminar"; break;
                case venClieHabitualActionEnum.EnumvenClieHabitualAction.DatosSucursal: lRetorno = "venClieHabitualDatosSucursal"; break;
                case venClieHabitualActionEnum.EnumvenClieHabitualAction.AdjuntosDatos: lRetorno = "venClieHabitualAdjuntosDatos"; break;
                case venClieHabitualActionEnum.EnumvenClieHabitualAction.AsignarLocalidad: lRetorno = "venClieHabitualAsignarLocalidad"; break;
                
                    
            }
            return lRetorno;
        }
    }
}
