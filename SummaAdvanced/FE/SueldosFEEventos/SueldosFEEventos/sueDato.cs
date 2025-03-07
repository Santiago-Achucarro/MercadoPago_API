using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    public class sueDato
    {
        public enum sueDatoVar
        {
            EsRetroActivo, EsHoraExtra
        }


        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesConceptos(SueldosCommon.sueDatoDS exch,
            SueldosCommon.sueDatoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            SueldosExchange.sueConceptosActionExchange eConcepto =
                    new SueldosExchange.sueConceptosActionExchange(SueldosExchange.sueConceptosActionEnum.EnumsueConceptosAction.Datos)
                    {
                        Concepto_Id = exchNoPost.Cuerpo[0].Concepto_Id
                    };
            eConcepto = new SueldosExchange.sueConceptosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eConcepto, cmd));
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            if (eConcepto.Existe)
            {
                lRetorno.Add(sueDatoVar.EsRetroActivo.ToString(), eConcepto.Retroactivo?"S":"N");
                lRetorno.Add(sueDatoVar.EsHoraExtra.ToString(), eConcepto.TipoPercepcion== "019"?"S":"N");
            }
            else
            {

                lRetorno.Add(sueDatoVar.EsRetroActivo.ToString(), "N");
                lRetorno.Add(sueDatoVar.EsHoraExtra.ToString(), "N");

            }
            return lRetorno;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public SueldosCommon.sueDatoDS SumarCant(SueldosCommon.sueDatoDS exch, SueldosCommon.sueDatoDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost.Cuerpo[0].Dato = exchNoPost.DatoRetro.ToList().Sum(r => r.Dato);
            exchNoPost.Cuerpo[0].Dato2 = exchNoPost.DatoRetro.ToList().Sum(r => r.Dato2);
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        [Generalidades.QFuncion_Condicion]
        public string EditaFechas(SueldosCommon.sueDatoDS pCommonDS, Framework.Core.Command cmd)
        {
            if (cmd.Dominio_Id == "MX")
                return "S";
            return "N";
        }
    }
}
