using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI Friday, June 28, 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace SueldosExchange{
        public static class sueGruposActionEnum
        {            public enum EnumsueGruposAction
            {
                Guardar,Datos,Eliminar
            }
        public static string GetAccionsueGruposAction(sueGruposActionEnum.EnumsueGruposAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case sueGruposActionEnum.EnumsueGruposAction.Guardar: lRetorno = "sueGruposGuardar"; break;
                case sueGruposActionEnum.EnumsueGruposAction.Datos: lRetorno = "sueGruposDevolverDatos"; break;
                case sueGruposActionEnum.EnumsueGruposAction.Eliminar: lRetorno = "sueGruposEliminar"; break;
            }
            return lRetorno;
        }
    }
}
