using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comMovPAnexo
    {

        public static comMovpAnexoDS Datos(long /*0*/pAsiento_Id, long /*1*/pTesMovimientos, int /*2*/pRenglonRengMovi, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pTesMovimientos, new Generalidades.NullableInt(/*2*/pRenglonRengMovi) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovpAnexoDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "conRenglonProv", "Provincia_id", "DescripcionProvincia", "Origen_Id", "DescripcioncomOrigenesFiscales", "CondFiscal_Id", "DescripcionCondFiscal", "XMLFiscal", "ClaveFiscal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Base_id", "DescripcionBase" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Cuenta_Id", "DescripcionCuenta", "Centro1_id", "DescripcionCentro1", "Centro2_id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            comMovpAnexoDS dsTipado = new comMovpAnexoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.grdImpuestos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(long /*0*/pAsiento_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovpAnexoEliminar", parametros);
        }

        public static void EliminarTes(long /*0*/pTesMovimientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTesMovimientos, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovpAnexoEliminarTes", parametros);
        }

        public static void Guardar(long /*0*/pAsiento_Id, long /*1*/pProvAnexo, long /*2*/ptesRengMovi_Id, int /*3*/pconRenglon, DateTime /*4*/pFecha_Ane, DateTime /*5*/pFecha_Libro_Iva, DateTime /*6*/pFecha_Contable, short /*7*/pOrigen_Id, string /*8*/pCondFiscal_Id, DateTime /*9*/pFechaCai, bool /*10*/pVieneDeFiscal, string /*11*/pXMLFiscal, string /*12*/pClaveFiscal, string /*13*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pProvAnexo, /*2*/ptesRengMovi_Id, /*3*/pconRenglon, /*4*/pFecha_Ane, /*5*/pFecha_Libro_Iva, /*6*/pFecha_Contable, new Generalidades.NullableShort(/*7*/pOrigen_Id), new Generalidades.NullableString(/*8*/pCondFiscal_Id), /*9*/pFechaCai, /*10*/pVieneDeFiscal, new Generalidades.NullableString(/*11*/pXMLFiscal), new Generalidades.NullableString(/*12*/pClaveFiscal) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovpAnexoGuardar", parametros);
        }






    }
}
