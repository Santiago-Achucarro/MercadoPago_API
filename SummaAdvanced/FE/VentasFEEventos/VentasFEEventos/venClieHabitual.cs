using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venClieHabitual
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public String ValidarFila(VentasCommon.venClieHabitualDS exch, VentasCommon.venClieHabitualDS exchNoPost, 
            int pIndice, Framework.Core.Command cmd)
        {
            VentasCommon.venClieHabitualDS.genJurisCoeficientesDataTable lRenglon = exchNoPost.genJurisCoeficientes;

            if (lRenglon[0].Juris_Id == "")
                return "Debe_ingresar_un_codigo_de_jurisdiccion";

            if (lRenglon[0].Coeficiente < 0)
                return "Debe_Ingresar_un_coeficiente_mayor_o_igual_a_cero";
            return "";

        }

        [Generalidades.QFuncion_Condicion]
        public string PideIBNB(VentasCommon.venClieHabitualDS exch, Framework.Core.Command cmd)
        {
            return (cmd.Dominio_Id == "AR" ? "S" : "N");

        }

        [Generalidades.QFuncion_Condicion]
        public string FacturaDeCredito(VentasCommon.venClieHabitualDS exch, Framework.Core.Command cmd)
        {
            return (exch.Principal[0].FacturaCredito ? "S" : "N");
        }

        [Generalidades.QFuncion_Condicion]
        public string PideIdFiscal(VentasCommon.venClieHabitualDS exch, Framework.Core.Command cmd)
        {
            // Si el país de facturación del cliente o es consumidar final que pida idFiscal //
            if (exch.Principal[0].Pais_Id_Fact != GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).Pais_Id ||
                exch.Principal[0].CUIT == "0" || exch.Principal[0].CUIT == "XAXX010101000" || exch.Principal[0].CUIT == "XEXX010101000")
                return "S";
            return "N";
        }

        public enum venClieHabitualVar
        {
            CuitExterior
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesCUITs(VentasCommon.venClieHabitualDS exch, VentasCommon.venClieHabitualDS exchNoPost, 
            int pIndice, Framework.Core.Command cmd)
        {
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            if(cmd.Dominio_Id == "MX" && exch.Principal[0].Pais_Id_Fact != GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).Pais_Id)
                lRetorno.Add(venClieHabitualVar.CuitExterior.ToString(), "XEX010101000");
            else
                lRetorno.Add(venClieHabitualVar.CuitExterior.ToString(), "");


            return lRetorno;
        }

        [Generalidades.QFuncion_ObtenerMascara]
        public string MascaraCuit(VentasCommon.venClieHabitualDS pCommonDS, VentasCommon.venClieHabitualDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            string lMascara = "";
            if(cmd.Dominio_Id == "AR" && (pCommonDS.Principal[0].TipoDoc == "1" || pCommonDS.Principal[0].TipoDoc == "2"))
                // Si es Cuit o Cuil cambio la máscara //
                lMascara = Generalidades.Mascaras.c_Mascara_CUIT;
            return lMascara;
        }
    }
}
