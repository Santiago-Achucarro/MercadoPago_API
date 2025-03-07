using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 31 de diciembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ContabilidadExchange{
        public static class conRubrosAxiActionEnum
        {            public enum EnumconRubrosAxiAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionconRubrosAxiAction(conRubrosAxiActionEnum.EnumconRubrosAxiAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case conRubrosAxiActionEnum.EnumconRubrosAxiAction.Guardar: lRetorno = "conRubrosAxiGuardar"; break;
                case conRubrosAxiActionEnum.EnumconRubrosAxiAction.Datos: lRetorno = "conRubrosAxiDevolverDatos"; break;
                case conRubrosAxiActionEnum.EnumconRubrosAxiAction.Eliminar: lRetorno = "conRubrosAxiEliminar"; break;
            }
            return lRetorno;
        }
    }
}
