using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralesExchange
{
    public static class genTareasProgramadasTodasActionEnum
    {
        public enum EnumgenTareasProgramadasTodasAction
        {
            Datos
        }
        public static string GetAcciongenTareasProgramadasTodasAction(genTareasProgramadasTodasActionEnum.EnumgenTareasProgramadasTodasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genTareasProgramadasTodasActionEnum.EnumgenTareasProgramadasTodasAction.Datos: lRetorno = "genTareasProgramadasTodasDevolverDatos"; break;
            }
            return lRetorno;
        }
    }

}
