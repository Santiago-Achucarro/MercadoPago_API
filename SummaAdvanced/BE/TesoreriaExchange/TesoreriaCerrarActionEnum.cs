using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 9 de abril de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class TesoreriaCerrarActionEnum
        {            public enum EnumTesoreriaCerrarAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionTesoreriaCerrarAction(TesoreriaCerrarActionEnum.EnumTesoreriaCerrarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case TesoreriaCerrarActionEnum.EnumTesoreriaCerrarAction.Guardar: lRetorno = "TesoreriaCerrarGuardar"; break;
                case TesoreriaCerrarActionEnum.EnumTesoreriaCerrarAction.Datos: lRetorno = "TesoreriaCerrarDevolverDatos"; break;
                case TesoreriaCerrarActionEnum.EnumTesoreriaCerrarAction.Eliminar: lRetorno = "TesoreriaCerrarEliminar"; break;
            }
            return lRetorno;
        }
    }
}
