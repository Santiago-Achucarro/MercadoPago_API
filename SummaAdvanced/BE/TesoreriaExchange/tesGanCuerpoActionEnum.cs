using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Saturday, June 25, 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesGanCuerpoActionEnum
        {            public enum EnumtesGanCuerpoAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesGanCuerpoAction(tesGanCuerpoActionEnum.EnumtesGanCuerpoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesGanCuerpoActionEnum.EnumtesGanCuerpoAction.Guardar: lRetorno = "tesGanCuerpoGuardar"; break;
                case tesGanCuerpoActionEnum.EnumtesGanCuerpoAction.Datos: lRetorno = "tesGanCuerpoDevolverDatos"; break;
                case tesGanCuerpoActionEnum.EnumtesGanCuerpoAction.Eliminar: lRetorno = "tesGanCuerpoEliminar"; break;
            }
            return lRetorno;
        }
    }
}
