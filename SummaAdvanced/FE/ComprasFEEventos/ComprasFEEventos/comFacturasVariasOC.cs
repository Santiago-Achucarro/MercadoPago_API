using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ComprasFEEventos
{
    public class comFacturasVariasOC
    {
        [Generalidades.QFuncion_Condicion]
        public string EsMonedaBase(ComprasCommon.comFacturasVariasOCDS exch, Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase || exch.Principal[0].Moneda_Id.Trim() == "")
                return "S";

            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string PideCuotas(ComprasCommon.comFacturasVariasOCDS exch, Command cmd)
        {

            return exch.Principal[0].CantCuotas > 1 ? "S" : "N";

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaImp(ComprasCommon.comFacturasVariasOCDS exch, ComprasCommon.comFacturasVariasOCDS exchNoPost,
           int pIndice, Command cmd)
        {
            ComprasCommon.comFacturasVariasOCDS.ImpuestosDataTable lDF = exchNoPost.Impuestos;

            if (lDF[0].Impuesto_Id == "")
                return "El_Impuesto_No_puede_ser_Vacio";


            return "";
        }

        public enum comFacturasVariasOCVar
        {
            UsaDescuento, CtaDtoPositivo, CtaDtoNegativo
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesDescuento(ComprasCommon.comFacturasVariasOCDS exch,
        ComprasCommon.comFacturasVariasOCDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            var eEmpresa = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);

            lRetorno.Add(comFacturasVariasOCVar.UsaDescuento.ToString(), eEmpresa.MontoDtoFinanciero == 0 ? "N" : "S");
            lRetorno.Add(comFacturasVariasOCVar.CtaDtoNegativo.ToString(), eEmpresa.CtaDtoFinNeg);
            lRetorno.Add(comFacturasVariasOCVar.CtaDtoPositivo.ToString(), eEmpresa.CtaDtoFinPos);

            return lRetorno;


        }

        [Generalidades.QFuncion_Condicion]
        public string DtoNegativo(ComprasCommon.comFacturasVariasOCDS exch, Command cmd)
        {
            if (exch.DescuentoFin[0].ImporteMonedaOriginal < 0)
                return "S";

            return "N";

        }
    }
}
