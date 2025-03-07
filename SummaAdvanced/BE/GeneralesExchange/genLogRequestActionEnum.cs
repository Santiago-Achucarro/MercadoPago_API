/// Generado por QBI miércoles, 21 de julio de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace GeneralesExchange
{
    public static class genLogRequestActionEnum
    {
        public enum EnumgenLogRequestAction
        {
            Guardar, Datos, Eliminar, EliminarXSeg
        }
        public static string GetAcciongenLogRequestAction(genLogRequestActionEnum.EnumgenLogRequestAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case genLogRequestActionEnum.EnumgenLogRequestAction.Guardar: lRetorno = "genLogRequestGuardar"; break;
                case genLogRequestActionEnum.EnumgenLogRequestAction.Datos: lRetorno = "genLogRequestDevolverDatos"; break;
                case genLogRequestActionEnum.EnumgenLogRequestAction.Eliminar: lRetorno = "genLogRequestEliminar"; break;
                case genLogRequestActionEnum.EnumgenLogRequestAction.EliminarXSeg: lRetorno = "genLogRequestEliminarXSeg"; break;
            }
            return lRetorno;
        }
    }
}
