using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
namespace GeneralesFEEventos
{

    public class genContadorSegmento
    {
        [Generalidades.QFuncion_Condicion]
        public string Dominio(GeneralesCommon.genContadorSegmentoDatosTodosDS Exch, Command cmd)
        {
            return cmd.Dominio_Id;

        }
        [Generalidades.QFuncion_CondicionGrilla]
        public string PrimerNumero(GeneralesCommon.genContadorSegmentoDatosTodosDS exch, GeneralesCommon.genContadorSegmentoDatosTodosDS exchNoPost, int pIndice, Command cmd)
        {
            if (exchNoPost.Cuerpo[0].PrimerNumero <= 0)
                return "El_Primer_Numero_Debe_Ser_Mayor_Que_Cero";
            return "";
        }


        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesSegmentos(GeneralesCommon.genContadorSegmentoDatosTodosDS exch,
           GeneralesCommon.genContadorSegmentoDatosTodosDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            GeneralesExchange.genSegmentosActionExchange ExcSeg = new GeneralesExchange.genSegmentosActionExchange(GeneralesExchange.genSegmentosActionEnum.EnumgenSegmentosAction.Datos)
            {
                Segmento_Id = exch.Principal[0].Segmento_Id
            };
            ExcSeg = new GeneralesExchange.genSegmentosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcSeg, cmd));
            if (ExcSeg.Existe)
                lRetorno.Add(genContadorSegmentoVar.TieneColumnaAutomatica.ToString(), ExcSeg.TieneColumnaAutomatica ? "true" : "false");
            else
            {
                lRetorno.Add(genContadorSegmentoVar.TieneColumnaAutomatica.ToString(), "false");
            }

            return lRetorno;

        }

        public enum genContadorSegmentoVar
        {
            TieneColumnaAutomatica
        }
    }
}
