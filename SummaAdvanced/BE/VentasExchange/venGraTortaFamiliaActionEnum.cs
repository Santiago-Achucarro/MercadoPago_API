using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 9 de octubre de 2020
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace VentasExchange{
        public static class venGraTortaFamiliaActionEnum
        {            public enum EnumvenGraTortaFamiliaAction
            {
                Datos
            }
        public static string GetAccionvenGraTortaFamiliaAction(venGraTortaFamiliaActionEnum.EnumvenGraTortaFamiliaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case venGraTortaFamiliaActionEnum.EnumvenGraTortaFamiliaAction.Datos: lRetorno = "venGraTortaFamiliaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
