using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI martes, 21 de mayo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proProgramasSegmentoActionEnum
        {            public enum EnumproProgramasSegmentoAction
            {
                Guardar
            }
        public static string GetAccionproProgramasSegmentoAction(proProgramasSegmentoActionEnum.EnumproProgramasSegmentoAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proProgramasSegmentoActionEnum.EnumproProgramasSegmentoAction.Guardar: lRetorno = "proProgramasSegmentoGuardar"; break;
            }
            return lRetorno;
        }
    }
}
