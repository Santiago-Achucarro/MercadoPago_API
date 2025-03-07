using System;
using System.Data;
using System.Runtime.Serialization;
/// Generado por QBI viernes, 28 de junio de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proExplosionActionEnum
        {            public enum EnumproExplosionAction
            {
                Explotar
            }
        public static string GetAccionproExplosionAction(proExplosionActionEnum.EnumproExplosionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proExplosionActionEnum.EnumproExplosionAction.Explotar: lRetorno = "proExplosionExplotar"; break;
            }
            return lRetorno;
        }
    }
}
