using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venMovConforma
    {
        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS Enviar(VentasCommon.venMovConformaDS pCommonDS, Framework.Core.Command cmd)
        {
            var eEmpre = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
            var eClie = VentasValidacion.venClientes.Existe(pCommonDS.Principal[0].Cliente_Id, cmd);

            VentasExchange.venClieHabitualActionExchange eClieS = VentasValidacion.venClieHabitual.Existe(eClie.Cliente_Id, eClie.SucursalPredeter, cmd);
            

            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();
            
            VentasExchange.venMovConformaActionExchange eMov = new VentasExchange.venMovConformaActionExchange(VentasExchange.venMovConformaActionEnum.EnumvenMovConformaAction.Datos)
            {
                Segmento_Id = pCommonDS.Principal[0].Segmento_Id,
                Segmento1N = pCommonDS.Principal[0].Segmento1N,
                Segmento2N = pCommonDS.Principal[0].Segmento2N,
                Segmento3N = pCommonDS.Principal[0].Segmento3N,
                Segmento4N = pCommonDS.Principal[0].Segmento4N,
                Segmento1C = pCommonDS.Principal[0].Segmento1C,
                Segmento2C = pCommonDS.Principal[0].Segmento2C,
                Segmento3C = pCommonDS.Principal[0].Segmento3C,
                Segmento4C = pCommonDS.Principal[0].Segmento4C
            };
            eMov = new VentasExchange.venMovConformaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));
            eMov.Action = VentasExchange.venMovConformaActionEnum.GetAccionvenMovConformaAction(VentasExchange.venMovConformaActionEnum.EnumvenMovConformaAction.AdjuntosDatos);
            eMov = new VentasExchange.venMovConformaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            string lCuerpo = "<p>Sres. " + pCommonDS.Principal[0].RazonSocial + "</p><p></p>";

            lCuerpo += "<p>Le Informamos que su Factura " + pCommonDS.Principal[0].Segmento1N.ToString() + pCommonDS.Principal[0].Segmento2C + " fue entregada, adjuntamos el comprobante.</p><p></p>";
            lCuerpo += "<p> Atte. Area de Logistica de " + eEmpre.RazonSocial+ "</p>";
            string lDestinatarios = "";

            foreach (var ren in eClieS.Param.grdContactos.Where(c => c.EnviaFacturas && !String.IsNullOrWhiteSpace(c.Email)))
            {
                lDestinatarios += ren.Email + ";";
            }

            lRetorno.Principal.AddPrincipalRow("Entregamos tu Factura",lCuerpo,
                    lDestinatarios, "", eEmpre.MailClientesSinMail, false);
            foreach (var ren in eMov.Param.Adjuntos)
            {
                lRetorno.Adjuntos.AddAdjuntosRow(ren.Renglon, ren.Guid, ren.NombreArchivo, ren.Extension,
                      ren.ArchivoBase64, ren.Estado);
            }
            return lRetorno;

        }
    }
}
