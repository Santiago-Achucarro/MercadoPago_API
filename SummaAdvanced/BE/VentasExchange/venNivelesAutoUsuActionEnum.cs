using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 29 de noviembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venNivelesAutoUsuActionEnum
        {            public enum EnumvenNivelesAutoUsuAction
            {
                Guardar,Eliminar
            }
        public static string GetAccionvenNivelesAutoUsuAction(venNivelesAutoUsuActionEnum.EnumvenNivelesAutoUsuAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venNivelesAutoUsuActionEnum.EnumvenNivelesAutoUsuAction.Guardar: lRetorno = "venNivelesAutoUsuGuardar"; break;
                case venNivelesAutoUsuActionEnum.EnumvenNivelesAutoUsuAction.Eliminar: lRetorno = "venNivelesAutoUsuEliminar"; break;
            }
            return lRetorno;
        }
    }
}
