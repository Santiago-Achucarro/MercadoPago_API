using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace TesoreriaFEEventos
{
    public class tesDepIdentificacion
    {
        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesDepIdentificacionDS Comprobantes(TesoreriaCommon.tesDepIdentificacionDS exch,
         TesoreriaCommon.tesDepIdentificacionDS exchNoPost, int pIndice, Command cmd)
        {

            VentasExchange.venTraePendientesActionExchange exchmc = new VentasExchange.venTraePendientesActionExchange(VentasExchange.venTraePendientesActionEnum.EnumvenTraePendientesAction.Datos);
            exchmc.venMovimientos = exchNoPost.Depositos[0].tesMovimientos;
            exchmc.Cliente_id = exchNoPost.Depositos[0].Cliente_Id;
            exchmc.Moneda_Id = exchNoPost.Depositos[0].Moneda_Id;
            exchmc.Signo = 1;
            exchmc = new VentasExchange.venTraePendientesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));

            exchNoPost.Aplicaciones.Clear();
            foreach (VentasCommon.venTraePendientesDS.PendientesRow ren in exchmc.Param.Pendientes)
            {
                exchNoPost.Aplicaciones.AddAplicacionesRow(exchNoPost.Depositos[0].tesMovimientos,
                    ren.venMovimientos, ren.SegmentoStr, ren.Fecha, ren.Importe, ren.Saldo, ren.CuotaNro, ren.ImporteAplicado, ren.FechaVencimiento);
            }
            exchNoPost.Aplicaciones.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesDepIdentificacionDS CompletarImportes(TesoreriaCommon.tesDepIdentificacionDS exch,
        TesoreriaCommon.tesDepIdentificacionDS exchNoPost, int pIndice, Command cmd)
        {

            decimal Acum = exchNoPost.Depositos[0].ImporteMonedaOriginal;
            foreach (var ren in exchNoPost.Aplicaciones)
            {
                ren.ImporteAplicado = Math.Min(ren.Saldo, Acum);
                Acum = Acum - ren.ImporteAplicado;
            }
            exchNoPost.Depositos[0].Saldo = Acum;
            return exchNoPost;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesDepIdentificacionDS CalcularSaldo(TesoreriaCommon.tesDepIdentificacionDS exch,
     TesoreriaCommon.tesDepIdentificacionDS exchNoPost, int pIndice, Command cmd)
        {

            exchNoPost.Depositos[0].Saldo = exchNoPost.Depositos[0].ImporteMonedaOriginal;
            foreach (var ren in exchNoPost.Aplicaciones)
            {

                exchNoPost.Depositos[0].Saldo -= ren.ImporteAplicado;
            }

            return exchNoPost;
        }
    }
}
