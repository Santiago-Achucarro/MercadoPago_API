using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

          
namespace VentasFEEventos
{
    public class venSubTipoMov
    {
        [Generalidades.QFuncion_Condicion]
        public string MueveStock(VentasCommon.venSubTipoMovDS exch, Framework.Core.Command cmd)
        {

            if (exch.Principal[0].MueveStock)
                return "S";

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string AdmiteStock(VentasCommon.venSubTipoMovDS exch, Framework.Core.Command cmd)
        {
            if ("FDR".Contains(exch.Principal[0].venTipoMov)) // ND también
                return "S";

            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string VaciaCuenta(VentasCommon.venSubTipoMovDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].CtaDefecto == "")
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string VaciaCentro1(VentasCommon.venSubTipoMovDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Centro1_Id == "")
                return "S";
            return "N";
        }


        [Generalidades.QFuncion_Condicion]
        public string VacioCentro2(VentasCommon.venSubTipoMovDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Centro2_Id == "")
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidadGrillaAfip(VentasCommon.venSubTipoMovDS exch, VentasCommon.venSubTipoMovDS exchNoPost,
            int pIndice, Framework.Core.Command cmd )
        {
            if (exchNoPost.venSTMAfip[0].Comprobante_Id == 0)
                return "Debe_informar_un_tipo_de_comprobante";
            return "";
        }
    }
}
