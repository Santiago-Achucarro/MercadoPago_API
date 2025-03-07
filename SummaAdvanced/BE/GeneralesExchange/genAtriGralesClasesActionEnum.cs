using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 21 de diciembre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange{
        public static class genAtriGralesClasesActionEnum
        {            public enum EnumgenAtriGralesClasesAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAcciongenAtriGralesClasesAction(genAtriGralesClasesActionEnum.EnumgenAtriGralesClasesAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genAtriGralesClasesActionEnum.EnumgenAtriGralesClasesAction.Guardar: lRetorno = "genAtriGralesClasesGuardar"; break;
                case genAtriGralesClasesActionEnum.EnumgenAtriGralesClasesAction.Datos: lRetorno = "genAtriGralesClasesDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
