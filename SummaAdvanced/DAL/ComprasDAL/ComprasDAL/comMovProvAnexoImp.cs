using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comMovProvAnexoImp
    {

        public static comMovProvAnexoImpDS Datos(long /*0*/pAsiento_Id, long /*1*/ptesMovimientos, int /*2*/pconRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/ptesMovimientos, new Generalidades.NullableInt(/*2*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovProvAnexoImpDatos", parametros);

            string[] camposTabla0 = { "Cuenta_id", "DescripcionCuenta", "Centro1_id", "DescripcionCentro1", "Centro2_id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comMovProvAnexoImpDS dsTipado = new comMovProvAnexoImpDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pAsiento_Id, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pconRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovProvAnexoImpEliminar", parametros);
        }


        public static void Insertar(long /*0*/pAsiento_Id, int /*1*/pconRenglon, string /*2*/pImpuesto_Id, decimal /*3*/pPorcentaje, decimal /*4*/pBase_Imponible, decimal /*5*/pImporte_Impuesto, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pconRenglon, /*2*/pImpuesto_Id, /*3*/pPorcentaje, /*4*/pBase_Imponible, /*5*/pImporte_Impuesto };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovProvAnexoImpInsertar", parametros);
        }


    }
}
