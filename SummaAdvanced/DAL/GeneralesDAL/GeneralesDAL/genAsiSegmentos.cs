using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genAsiSegmentos
    {
        public static genAsiSegmentosDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAsiSegmentosDatos", parametros);

            string[] camposTabla0 = { "Segmento_Str" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genAsiSegmentosDS dsTipado = new genAsiSegmentosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genAsiSegmentosEliminar", parametros);
        }

        public static Int32 Guardar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, long /*10*/pAsiento_Id, bool /*11*/pTieneAutomatico, bool /*12*/pPosteado, string /*13*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pAsiento_Id, /*11*/pTieneAutomatico, /*12*/pPosteado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (Int32) oiDAAB.guardar("genAsiSegmentosGuardar", parametros);
        }

        public static genAsiSegmentosDS DatosInt(long /*0*/pAsiento_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAsiSegmentosDatosInt", parametros);

            string[] camposTabla0 = { "Segmento_Str" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genAsiSegmentosDS dsTipado = new genAsiSegmentosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Modificar1N(long /*0*/pAsiento_Id, int /*1*/pSegmento1N, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pSegmento1N };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genAsiSegmentosModificar1N", parametros);
        }
    }
}
