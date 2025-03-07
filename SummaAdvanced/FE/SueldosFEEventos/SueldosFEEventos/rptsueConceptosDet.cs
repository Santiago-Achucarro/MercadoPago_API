using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;

namespace SueldosFEEventos
{
    class rptsueConceptosDet
    {
        [Generalidades.QFuncion_AccionFE]
        public SueldosReportesCommon.sueConceptosLiqDetDS VezActiva(SueldosReportesCommon.sueConceptosLiqDetDS pCommonDS, Command cmd)
        {
            if (pCommonDS.Principal[0].Anio == 0)
            {
                SueldosReportesCommon.sueConceptosLiqDetDS res = new SueldosReportesCommon.sueConceptosLiqDetDS();
                res.Merge(SueldosValidacion.sueVezActiva.Asignar(new Exchange("", pCommonDS), cmd).RawDataSet, false, System.Data.MissingSchemaAction.Ignore);
                return res;
            }
            else
                return pCommonDS;
        }
    }
}
