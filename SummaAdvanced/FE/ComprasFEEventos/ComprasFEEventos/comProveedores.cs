using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework.Core;


namespace ComprasFEEventos
{
    public class comProveedores
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaCtaPasivo(ComprasCommon.comProveedoresDS exch, ComprasCommon.comProveedoresDS exchNoPost, 
            int pIndice, Command cmd)
        {
            ComprasCommon.comProveedoresDS.CtasPasivoDataTable lDF = exchNoPost.CtasPasivo;

            if (lDF[0].Cuenta_Id == "")
                return "La_Cuenta_No_puede_ser_Vacia";

            ContabilidadValidacion.conCuentas.ExistePosteadoActivaImputableNoReservada(lDF[0].Cuenta_Id, "COM", cmd);
            if (lDF[0].ctaPagoXAdelantado != "")
                ContabilidadValidacion.conCuentas.ExistePosteadoActivaImputableNoReservada(lDF[0].ctaPagoXAdelantado, "COM", cmd);

            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaCtaContra(ComprasCommon.comProveedoresDS exch, ComprasCommon.comProveedoresDS exchNoPost, 
            int pIndice, Command cmd)
        {

            ComprasCommon.comProveedoresDS.CtasContraPartidaDataTable lDF = exchNoPost.CtasContraPartida;

            if (lDF[0].Cuenta_Id == "")
                return "La_Cuenta_No_puede_ser_Vacia";

            ContabilidadValidacion.conCuentas.ExistePosteadoActivaImputableNoReservada(lDF[0].Cuenta_Id, "COM", cmd);
            ContabilidadValidacion.conCentro1.ExistePosteadoyActivo(lDF[0].Centro1_Id,cmd);
            ContabilidadValidacion.conCentro2.ExistePosteadoyActivo(lDF[0].Centro2_Id,cmd);

            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaImpuestos(ComprasCommon.comProveedoresDS exch, ComprasCommon.comProveedoresDS exchNoPost, 
            int pIndice, Command cmd)
        {
            ComprasCommon.comProveedoresDS.ImpuestosDataTable lDF = exchNoPost.Impuestos;

            if (lDF[0].Impuesto_Id == "")
                return "El_Impuesto_No_puede_ser_Vacio";

            ComprasValidacion.comImpuestos.ExistePosteadoyActiva(lDF[0].Impuesto_Id, cmd);
            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaJuris(ComprasCommon.comProveedoresDS exch, ComprasCommon.comProveedoresDS exchNoPost,
            int pIndice, Command cmd)
        {
            ComprasCommon.comProveedoresDS.genJurisCoeficientesDataTable lDF = exchNoPost.genJurisCoeficientes;

            if (lDF[0].Juris_Id == "")
                return "La_jurisdiccion_No_puede_ser_Vacio";

            ImpuestosValidacion.impJurisdicciones.ExistePosteadoyActivo(lDF[0].Juris_Id, cmd);
            return "";
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaRet(ComprasCommon.comProveedoresDS exch, ComprasCommon.comProveedoresDS exchNoPost,
            int pIndice, Command cmd)
        {
            ComprasCommon.comProveedoresDS.RetencionesDataTable lDF = exchNoPost.Retenciones;

            if (lDF[0].Cartera_Id == "")
                return "La_cartera_No_puede_ser_vacia";

            TesoreriaValidacion.tesIdRetProv.ExistePosteadoyActivo(lDF[0].Cartera_Id, cmd);
            return "";
        }
    }
}
