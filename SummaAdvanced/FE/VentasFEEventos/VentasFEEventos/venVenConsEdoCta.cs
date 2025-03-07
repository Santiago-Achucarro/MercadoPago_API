using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venVenConsEdoCta
    {
        [Generalidades.QFuncion_Condicion]
        public string Segmento1C(VentasCommon.VenConsEdoCtaDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genSegmentosActionExchange ExcS = 
                GeneralesValidacion.genSegmentos.Existe("FC", cmd);
            return ExcS.Orden1C==0?"N":"S";
        }
        [Generalidades.QFuncion_Condicion]
        public string Segmento2C(VentasCommon.VenConsEdoCtaDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genSegmentosActionExchange ExcS =
                GeneralesValidacion.genSegmentos.Existe("FC", cmd);
            return ExcS.Orden2C == 0 ? "N" : "S";
        }
        [Generalidades.QFuncion_Condicion]
        public string Segmento3C(VentasCommon.VenConsEdoCtaDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genSegmentosActionExchange ExcS =
                GeneralesValidacion.genSegmentos.Existe("FC", cmd);
            return ExcS.Orden3C == 0 ? "N" : "S";
        }

        [Generalidades.QFuncion_Condicion]
        public string Segmento4C(VentasCommon.VenConsEdoCtaDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genSegmentosActionExchange ExcS =
                GeneralesValidacion.genSegmentos.Existe("FC", cmd);
            return ExcS.Orden4C == 0 ? "N" : "S";
        }

        [Generalidades.QFuncion_Condicion]
        public string Segmento1N(VentasCommon.VenConsEdoCtaDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genSegmentosActionExchange ExcS =
                GeneralesValidacion.genSegmentos.Existe("FC", cmd);
            return ExcS.Orden1N == 0 ? "N" : "S";
        }

        [Generalidades.QFuncion_Condicion]
        public string Segmento2N(VentasCommon.VenConsEdoCtaDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genSegmentosActionExchange ExcS =
                GeneralesValidacion.genSegmentos.Existe("FC", cmd);
            return ExcS.Orden2N == 0 ? "N" : "S";
        }

        [Generalidades.QFuncion_Condicion]
        public string Segmento3N(VentasCommon.VenConsEdoCtaDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genSegmentosActionExchange ExcS =
                GeneralesValidacion.genSegmentos.Existe("FC", cmd);
            return ExcS.Orden3N == 0 ? "N" : "S";
        }

        [Generalidades.QFuncion_Condicion]
        public string Segmento4N(VentasCommon.VenConsEdoCtaDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genSegmentosActionExchange ExcS =
                GeneralesValidacion.genSegmentos.Existe("FC", cmd);
            return ExcS.Orden4N == 0 ? "N" : "S";
        }


        [Generalidades.QFuncion_Condicion]
        public string PendOHist(VentasCommon.VenConsEdoCtaDS exch, Framework.Core.Command cmd)
        {
            return exch.Principal[0].Pendiente ? "P" : "H";
        }

        [Generalidades.QFuncion_Condicion]
        public string EnMonedaBase(VentasCommon.VenConsEdoCtaDS exch, Framework.Core.Command cmd)
        {
            return exch.Principal[0].Moneda_Id == cmd.MonedaBase ? "S" : "N";
        }


    }
}
