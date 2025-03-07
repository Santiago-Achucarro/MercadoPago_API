using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 2 de agosto de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proExistenciaActionEnum
        {            public enum EnumproExistenciaAction
            {
                Datos
            }
        public static string GetAccionproExistenciaAction(proExistenciaActionEnum.EnumproExistenciaAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proExistenciaActionEnum.EnumproExistenciaAction.Datos: lRetorno = "proExistenciaDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
