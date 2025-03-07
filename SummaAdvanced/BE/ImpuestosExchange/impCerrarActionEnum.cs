using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 21 de mayo de 2018
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impCerrarActionEnum
        {            public enum EnumimpCerrarAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionimpCerrarAction(impCerrarActionEnum.EnumimpCerrarAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impCerrarActionEnum.EnumimpCerrarAction.Guardar: lRetorno = "impCerrarGuardar"; break;
                case impCerrarActionEnum.EnumimpCerrarAction.Datos: lRetorno = "impCerrarDevolverDatos"; break;
                case impCerrarActionEnum.EnumimpCerrarAction.Eliminar: lRetorno = "impCerrarEliminar"; break;
            }
            return lRetorno;
        }
    }
}
