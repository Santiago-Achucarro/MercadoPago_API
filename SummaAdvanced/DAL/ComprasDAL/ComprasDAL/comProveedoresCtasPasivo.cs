using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comProveedoresCtasPasivo
    {
        public static comProveedoresCtasPasivoDS Datos(long /*0*/pgenEntidades, int /*1*/pTipoCtaProv, string /*2*/pMoneda_Id, 
            string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades, new Generalidades.NullableInt(/*1*/pTipoCtaProv),
                new Generalidades.NullableString(/*2*/pMoneda_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comProveedoresCtasPasivoDatos", parametros);

            string[] camposTabla0 = { "ctaPagoXAdelantado", "DescripcionctaPagoXAdelantado", "CtaAnticipo", "DescripcionCtaAnticipo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comProveedoresCtasPasivoDS dsTipado = new comProveedoresCtasPasivoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pgenEntidades, int /*1*/pTipoCtaProv, string /*2*/pMoneda_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades, new Generalidades.NullableInt(/*1*/pTipoCtaProv),
                new Generalidades.NullableString(/*2*/pMoneda_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comProveedoresCtasPasivoEliminar", parametros);
        }


        public static void Guardar(long /*0*/pgenEntidades, int /*1*/pTipoCtaProv, string /*2*/pMoneda_Id, string /*3*/pCuenta_Id, 
            string /*4*/pctaPagoXAdelantado, string /*5*/pCtaAnticipo, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades, /*1*/pTipoCtaProv, /*2*/pMoneda_Id, /*3*/pCuenta_Id,
                /*4*/pctaPagoXAdelantado, /*5*/pCtaAnticipo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comProveedoresCtasPasivoInsertar", parametros);
        }
    }
}
