using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 21 de junio de 2016
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impJurisdiccionesActionEnum
        {            public enum EnumimpJurisdiccionesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionimpJurisdiccionesAction(impJurisdiccionesActionEnum.EnumimpJurisdiccionesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impJurisdiccionesActionEnum.EnumimpJurisdiccionesAction.Guardar: lRetorno = "impJurisdiccionesGuardar"; break;
                case impJurisdiccionesActionEnum.EnumimpJurisdiccionesAction.Datos: lRetorno = "impJurisdiccionesDevolverDatos"; break;
                case impJurisdiccionesActionEnum.EnumimpJurisdiccionesAction.Eliminar: lRetorno = "impJurisdiccionesEliminar"; break;
            }
            return lRetorno;
        }
    }
}
