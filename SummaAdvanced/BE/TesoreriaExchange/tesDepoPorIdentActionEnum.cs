using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 15 de septiembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesDepoPorIdentActionEnum
        {            public enum EnumtesDepoPorIdentAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesDepoPorIdentAction(tesDepoPorIdentActionEnum.EnumtesDepoPorIdentAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesDepoPorIdentActionEnum.EnumtesDepoPorIdentAction.Guardar: lRetorno = "tesDepoPorIdentGuardar"; break;
                case tesDepoPorIdentActionEnum.EnumtesDepoPorIdentAction.Datos: lRetorno = "tesDepoPorIdentDevolverDatos"; break;
                case tesDepoPorIdentActionEnum.EnumtesDepoPorIdentAction.Eliminar: lRetorno = "tesDepoPorIdentEliminar"; break;
            }
            return lRetorno;
        }
    }
}
