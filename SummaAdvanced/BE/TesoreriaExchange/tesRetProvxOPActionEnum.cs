using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 11 de febrero de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange{
        public static class tesRetProvxOPActionEnum
        {            public enum EnumtesRetProvxOPAction
            {
                Datos
            }
        public static string GetAcciontesRetProvxOPAction(tesRetProvxOPActionEnum.EnumtesRetProvxOPAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesRetProvxOPActionEnum.EnumtesRetProvxOPAction.Datos: lRetorno = "tesRetProvxOPDevolverDatos"; break;
            }
            return lRetorno;
        }
    }
}
