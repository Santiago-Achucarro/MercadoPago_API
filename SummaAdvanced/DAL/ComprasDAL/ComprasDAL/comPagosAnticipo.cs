using ComprasCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
    public class comPagosAnticipo
    {
        public static comPagosAnticipoDS Datos(string /*0*/pProveed_Id, string /*1*/pMoneda_Id, int /*2*/pEmpresa_Id, DateTime /*3*/pFechaPago, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, /*1*/pMoneda_Id, /*2*/pEmpresa_Id, new Generalidades.NullableDate(/*3*/pFechaPago) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comPagosAnticipoDatos", parametros);

            string[] camposTabla0 = { "FechaPago", "tesMovimientos", "comEmbarques", "Empresa_Id", "Segmento_Id", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "SegmentoStr" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comPagosAnticipoDS dsTipado = new comPagosAnticipoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }






        public static void Eliminar(string /*0*/pProveed_Id, string /*1*/pMoneda_Id, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, /*1*/pMoneda_Id, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comPagosAnticipoEliminar", parametros);
        }
        public static void Guardar(string /*0*/pProveed_Id, string /*1*/pMoneda_Id, int /*2*/pEmpresa_Id, decimal /*3*/pImporte, int /*4*/pTipoCtaProv, string /*5*/pCuenta_Id, int /*6*/pUsuario_Id, long /*7*/ptesMovimientos, long /*8*/pcomEmbarque, DateTime /*9*/pFechaPago, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, /*1*/pMoneda_Id, /*2*/pEmpresa_Id, /*3*/pImporte, /*4*/pTipoCtaProv, /*5*/pCuenta_Id, /*6*/pUsuario_Id, /*7*/new Generalidades.NullableInt64(ptesMovimientos), /*8*/new Generalidades.NullableInt64(pcomEmbarque), /*9*/pFechaPago };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comPagosAnticipoGuardar", parametros);
        }


        public static void MarcarPagado(long /*0*/pcomPagosAnticipo, long /*1*/ptesMovimietnos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomPagosAnticipo, /*1*/ptesMovimietnos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comPagosAnticipoMarcarPagado", parametros);
        }




    }
}
