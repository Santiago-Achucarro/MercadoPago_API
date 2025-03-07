using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Saturday, June 25, 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesGananciasActionEnum
        {            public enum EnumtesGananciasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciontesGananciasAction(tesGananciasActionEnum.EnumtesGananciasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesGananciasActionEnum.EnumtesGananciasAction.Guardar: lRetorno = "tesGananciasGuardar"; break;
                case tesGananciasActionEnum.EnumtesGananciasAction.Datos: lRetorno = "tesGananciasDevolverDatos"; break;
                case tesGananciasActionEnum.EnumtesGananciasAction.Eliminar: lRetorno = "tesGananciasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
