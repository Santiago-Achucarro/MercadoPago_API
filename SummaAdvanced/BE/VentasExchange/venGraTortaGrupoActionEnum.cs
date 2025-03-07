using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 9 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venGraTortaGrupoActionEnum
        {            public enum EnumvenGraTortaGrupoAction
            {
                Datos
            }
        public static string GetAccionvenGraTortaGrupoAction(venGraTortaGrupoActionEnum.EnumvenGraTortaGrupoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venGraTortaGrupoActionEnum.EnumvenGraTortaGrupoAction.Datos: lRetorno = "venGraTortaGrupoDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
