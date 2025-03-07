using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesIdRetProv
    {
        public static tesIdRetProvDS Datos(string /*0*/pCartera_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesIdRetProvDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpreas", "Cuenta_Id", "DescripcionCuentas", "Moneda_Id", "DescripcionMonedas",
                "UsuarioAmo", "DescripcionUsuarioAmo", "CtaValEnTransito", "DescripcionCtaValEnTransito", "TipoCtaProv", "Concepto", "Reporte_Id","FormaDePagoP" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesIdRetProvDS dsTipado = new tesIdRetProvDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pCartera_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesIdRetProvEliminar", parametros);
        }

        public static void Guardar(string /*0*/pCartera_Id, string /*1*/pFormula, string /*2*/pSegmento_Id, int /*3*/pTipoImpuesto, 
            decimal /*4*/pNroResSicore, int /*5*/pTipoCtaProv, string /*6*/pConcepto, decimal /*7*/pPorcentaje, string /*8*/pUsuarioFirmante, 
            decimal /*9*/pMinimo, bool /*10*/pGenRetxFact, string /*11*/pReporte_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pFormula, /*2*/pSegmento_Id, /*3*/pTipoImpuesto, /*4*/pNroResSicore,
                new Generalidades.NullableInt(/*5*/pTipoCtaProv), new Generalidades.NullableString(/*6*/pConcepto), /*7*/pPorcentaje, /*8*/pUsuarioFirmante, /*9*/pMinimo,
                /*10*/pGenRetxFact, /*11*/pReporte_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesIdRetProvGuardar", parametros);
        }

    }
}
