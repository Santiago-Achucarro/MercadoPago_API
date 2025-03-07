using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 14 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venFactAnulHastaActionEnum
        {            public enum EnumvenFactAnulHastaAction
            {
                Guardar
            }
        public static string GetAccionvenFactAnulHastaAction(venFactAnulHastaActionEnum.EnumvenFactAnulHastaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venFactAnulHastaActionEnum.EnumvenFactAnulHastaAction.Guardar: lRetorno = "venFactAnulHastaGuardar"; break;
            }
            return lRetorno;
        }
    }
}
