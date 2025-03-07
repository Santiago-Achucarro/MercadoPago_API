using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 10 de septiembre de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueVariableGrupoActionEnum
        {            public enum EnumsueVariableGrupoAction
            {
                Datos
            }
        public static string GetAccionsueVariableGrupoAction(sueVariableGrupoActionEnum.EnumsueVariableGrupoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueVariableGrupoActionEnum.EnumsueVariableGrupoAction.Datos: lRetorno = "sueVariableGrupoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
