using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conMovCont
    {
        public static conMovContDS Datos(long /*0*/pconAsientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conMovContDatos", parametros);

            string[] camposTabla0 = { "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            conMovContDS dsTipado = new conMovContDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pconAsientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conMovContEliminar", parametros);
        }

        public static void Guardar(long /*0*/pconAsientos, int /*1*/pRenglon, string /*2*/pCuenta_Id, string /*3*/pLeyendaLibroMayor, decimal /*4*/pImporte, decimal /*5*/pImporteMonedaOriginal, decimal /*6*/pTipoMov, string /*7*/pCentro1_Id, string /*8*/pCentro2_Id, string /*9*/pClase, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, /*1*/pRenglon, new Generalidades.NullableString(/*2*/pCuenta_Id), /*3*/pLeyendaLibroMayor, /*4*/pImporte, /*5*/pImporteMonedaOriginal, /*6*/pTipoMov, new Generalidades.NullableString(/*7*/pCentro1_Id), new Generalidades.NullableString(/*8*/pCentro2_Id), /*9*/pClase };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conMovContGuardar", parametros);
        }



    }
}
