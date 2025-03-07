/// Generado por QBI viernes, 20 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace TesoreriaExchange
{
    public static class tesT3PromocionesCuotasActionEnum
    {
        public enum EnumtesT3PromocionesCuotasAction
        {
            Guardar, Eliminar, CalcularCuotas
        }
        public static string GetAcciontesT3PromocionesCuotasAction(tesT3PromocionesCuotasActionEnum.EnumtesT3PromocionesCuotasAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case tesT3PromocionesCuotasActionEnum.EnumtesT3PromocionesCuotasAction.Guardar: lRetorno = "tesT3PromocionesCuotasGuardar"; break;
                case tesT3PromocionesCuotasActionEnum.EnumtesT3PromocionesCuotasAction.Eliminar: lRetorno = "tesT3PromocionesCuotasEliminar"; break;
                case tesT3PromocionesCuotasActionEnum.EnumtesT3PromocionesCuotasAction.CalcularCuotas: lRetorno = "tesT3PromocionesCuotasCalcularCuotas"; break;
            }
            return lRetorno;
        }
    }
}
