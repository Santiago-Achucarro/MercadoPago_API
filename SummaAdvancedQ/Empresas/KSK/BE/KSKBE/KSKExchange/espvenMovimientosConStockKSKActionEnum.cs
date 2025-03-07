/// Generado por QBI lunes, 23 de agosto de 2021
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace KSKExchange
{
    public static class espvenMovimientosConStockKSKActionEnum
    {
        public enum EnumespvenMovimientosConStockKSKAction
        {
            Guardar, Cobrar, LeerCodBarra, AsignaSaldoCobra, TraerMediosPago, LeerPadron, GuardarFiscal, GuardarCliente, EnviarFacturaPorMail, EnviaKSK, 
            MPBorrarOrden, MPEscanearOrden
        }
        public static string GetAccionespvenMovimientosConStockKSKAction(espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction.Guardar: lRetorno = "espvenMovimientosConStockKSKGuardar"; break;
                case espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction.Cobrar: lRetorno = "espvenMovimientosConStockKSKCobrar"; break;
                case espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction.LeerCodBarra: lRetorno = "espvenMovimientosConStockKSKLeerCodBarra"; break;
                case espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction.AsignaSaldoCobra: lRetorno = "espvenMovimientosConStockKSKAsignaSaldoCobra"; break;
                case espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction.TraerMediosPago: lRetorno = "espvenMovimientosConStockKSKTraerMediosPago"; break;
                case espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction.LeerPadron: lRetorno = "espvenMovimientosConStockKSKLeerPadron"; break;
                case espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction.GuardarFiscal: lRetorno = "espvenMovimientosConStockKSKGuardarFiscal"; break;
                case espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction.GuardarCliente: lRetorno = "espvenMovimientosConStockKSKGuardarCliente"; break;
                case espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction.EnviarFacturaPorMail: lRetorno = "espvenMovimientosConStockKSKEnviarFacturaPorMail"; break;
                case espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction.EnviaKSK: lRetorno = "espvenMovimientosConStockKSKEnviaKSK"; break;
                case espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction.MPBorrarOrden: lRetorno = "espvenMovimientosConStockKSKMPBorrarOrden"; break;
                case espvenMovimientosConStockKSKActionEnum.EnumespvenMovimientosConStockKSKAction.MPEscanearOrden: lRetorno = "espvenMovimientosConStockKSKMPEscanearOrden"; break;


            }
            return lRetorno;
        }
    }
}
