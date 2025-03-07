using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI miércoles, 15 de septiembre de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesDepoPorIdentImpActionEnum
        {            public enum EnumtesDepoPorIdentImpAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesDepoPorIdentImpAction(tesDepoPorIdentImpActionEnum.EnumtesDepoPorIdentImpAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesDepoPorIdentImpActionEnum.EnumtesDepoPorIdentImpAction.Guardar: lRetorno = "tesDepoPorIdentImpGuardar"; break;
                case tesDepoPorIdentImpActionEnum.EnumtesDepoPorIdentImpAction.Datos: lRetorno = "tesDepoPorIdentImpDevolverDatos"; break;
                case tesDepoPorIdentImpActionEnum.EnumtesDepoPorIdentImpAction.Eliminar: lRetorno = "tesDepoPorIdentImpEliminar"; break;
            }
            return lRetorno;
        }
    }
}
