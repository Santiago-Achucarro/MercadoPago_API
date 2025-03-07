using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 22 de julio de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ImpuestosExchange{
        public static class impFormulasActionEnum
        {            public enum EnumimpFormulasAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionimpFormulasAction(impFormulasActionEnum.EnumimpFormulasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case impFormulasActionEnum.EnumimpFormulasAction.Guardar: lRetorno = "impFormulasGuardar"; break;
                case impFormulasActionEnum.EnumimpFormulasAction.Datos: lRetorno = "impFormulasDevolverDatos"; break;
                case impFormulasActionEnum.EnumimpFormulasAction.Eliminar: lRetorno = "impFormulasEliminar"; break;
            }
            return lRetorno;
        }
    }
}
