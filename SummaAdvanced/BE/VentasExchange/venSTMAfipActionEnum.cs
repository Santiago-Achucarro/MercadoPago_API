using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 30 de mayo de 2017
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venSTMAfipActionEnum
        {            public enum EnumvenSTMAfipAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionvenSTMAfipAction(venSTMAfipActionEnum.EnumvenSTMAfipAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venSTMAfipActionEnum.EnumvenSTMAfipAction.Guardar: lRetorno = "venSTMAfipGuardar"; break;
                case venSTMAfipActionEnum.EnumvenSTMAfipAction.Eliminar: lRetorno = "venSTMAfipEliminar"; break;
            }
            return lRetorno;
        }
    }
}
