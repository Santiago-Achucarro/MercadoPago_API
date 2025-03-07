using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    public class sueDatoXConcepto
    {
        [Generalidades.QFuncion_Condicion]
        public string EsRetroActivo(SueldosCommon.sueDatoXConceptoDS exch, Framework.Core.Command cmd)
        {
            SueldosExchange.sueConceptosActionExchange eConcepto =
                    new SueldosExchange.sueConceptosActionExchange(SueldosExchange.sueConceptosActionEnum.EnumsueConceptosAction.Datos)
                    {
                        Concepto_Id = exch.Principal[0].Concepto_Id
                    };
            eConcepto = new SueldosExchange.sueConceptosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eConcepto, cmd));

            if (eConcepto.Retroactivo)
                return "S";
            return "N";
        }


        [Generalidades.QFuncion_Condicion]
        public string EsHoraExtra(SueldosCommon.sueDatoXConceptoDS exch, Framework.Core.Command cmd)
        {
            SueldosExchange.sueConceptosActionExchange eConcepto =
                    new SueldosExchange.sueConceptosActionExchange(SueldosExchange.sueConceptosActionEnum.EnumsueConceptosAction.Datos)
                    {
                        Concepto_Id = exch.Principal[0].Concepto_Id
                    };
            eConcepto = new SueldosExchange.sueConceptosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eConcepto, cmd));

            if (eConcepto.TipoPercepcion == "019")
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_AccionGrilla]
        public SueldosCommon.sueDatoXConceptoDS SumarCant(SueldosCommon.sueDatoXConceptoDS exch, SueldosCommon.sueDatoXConceptoDS exchNoPost,
          int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost.Cuerpo[0].Dato = exchNoPost.DatosRetro.ToList().Sum(r => r.Dato);
            exchNoPost.Cuerpo[0].Dato2 = exchNoPost.DatosRetro.ToList().Sum(r => r.Dato2);
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        [Generalidades.QFuncion_Condicion]
        public string EditaFechas(SueldosCommon.sueDatoXConceptoDS pCommonDS, Framework.Core.Command cmd)
        {
            if (cmd.Dominio_Id == "MX")
                return "S";
            return "N";
        }
    }
}
