using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
namespace ComprasFEEventos
{
    public class comEmbarqueEdtoCta
    {
        
        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public String ObtenerParametrosRepo(ComprasCommon.comEmbarqueEdtoCtaDS exch, Framework.Core.Command cmd)
        {
            string a = "Segmento_Id|" + exch.Principal[0].Segmento_Id +
              "@Segmento1N|" + exch.Principal[0].Segmento1N.ToString() +
              "@Segmento2N|" + exch.Principal[0].Segmento2N.ToString() +
              "@Segmento3N|" + exch.Principal[0].Segmento3N.ToString() +
              "@Segmento4N|" + exch.Principal[0].Segmento4N.ToString() +
              "@Segmento1C|" + exch.Principal[0].Segmento1C +
              "@Segmento2C|" + exch.Principal[0].Segmento2C +
              "@Segmento3C|" + exch.Principal[0].Segmento3C +
              "@Segmento4C|" + exch.Principal[0].Segmento4C +
              "@Empresa_Id|" + cmd.Empresa_Id.ToString();

            return a;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comEmbarqueEdtoCtaDS Comprobantes(ComprasCommon.comEmbarqueEdtoCtaDS exch,
       ComprasCommon.comEmbarqueEdtoCtaDS exchNoPost, int pIndice, Command cmd)
        {
            if (exch.Cuerpo[pIndice].Saldo == 0)
                Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_saldo_para_aplicar");

            int lSigno = 0;
            if (exch.Cuerpo[pIndice].Debe > 0)
                lSigno = 1;
            else
                lSigno = -1;
            exch.Aplicados.Clear();
            foreach (ComprasCommon.comEmbarqueEdtoCtaDS.CuerpoRow ren in exch.Cuerpo)
            {
                if (ren.Saldo != 0)
                { 
                    if ((lSigno == 1) && (ren.Haber > 0))
                        exch.Aplicados.AddAplicadosRow(ren.comMovProv, ren.SegmentoStr, ren.CuotaNro, ren.RazonSocial, ren.Haber, 
                                ren.Saldo * (ren.Moneda_Id==exch.Principal[0].Moneda_Id? exch.Principal[0].Cambio:1), ren.Cambio, ren.Moneda_Id, 0, ren.Fecha_CCP);
                    if ((lSigno == -1) && (ren.Debe > 0))
                        exch.Aplicados.AddAplicadosRow(ren.comMovProv, ren.SegmentoStr, ren.CuotaNro, ren.RazonSocial, ren.Debe, 
                            ren.Saldo * (ren.Moneda_Id == exch.Principal[0].Moneda_Id ? exch.Principal[0].Cambio : 1), ren.Cambio, ren.Moneda_Id, 0, ren.Fecha_CCP);
                }
            }
            exch.Aplicados.AcceptChanges();
            exch.CompAplic.Clear();
            exch.CompAplic.AddCompAplicRow(exch.Cuerpo[pIndice].comMovProv, exch.Cuerpo[pIndice].CuotaNro, exchNoPost.Cuerpo[0].Saldo, lSigno, exch.Cuerpo[pIndice].Cambio,
                    exch.Cuerpo[pIndice].Moneda_Id, 
                    exch.Cuerpo[pIndice].Saldo * (exch.Cuerpo[pIndice].Moneda_Id== exch.Principal[0].Moneda_Id ? exch.Principal[0].Cambio : 1), GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd).Date);
            exch.CompAplic.AcceptChanges();

            if (exch.Aplicados.Count == 0)
                Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_contra_que_aplicar");

            return exch;
        }

        
    }
}
