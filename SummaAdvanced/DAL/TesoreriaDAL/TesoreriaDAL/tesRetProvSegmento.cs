using interfaceDAAB;
using System;
using System.Data;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesRetProvSegmento
    {
        //public static tesRetProvSegmentoDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, 
        //    int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C,
        //    string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        //{
        //    Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N,
        //        /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

        //    iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

        //    DataSet ds = oiDAAB.getObject("tesRetProvSegmentoDatos", parametros);

        //    string[] camposTabla0 = { "tesMovimientos", "conRenglon" };
        //    Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

        //    tesRetProvSegmentoDS dsTipado = new tesRetProvSegmentoDS();
        //    string[] nombreTablas = { dsTipado.Principal.TableName };
        //    Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
        //    dsTipado.Merge(ds);
        //    return (dsTipado);
        //}

        
        //public static void Eliminar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N,
        //    int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C,
        //    string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        //{
        //    Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, new Generalidades.NullableInt(/*2*/pSegmento1N),
        //        new Generalidades.NullableInt(/*3*/pSegmento2N), new Generalidades.NullableInt(/*4*/pSegmento3N),
        //        new Generalidades.NullableInt(/*5*/pSegmento4N), new Generalidades.NullableString(/*6*/pSegmento1C),
        //        new Generalidades.NullableString(/*7*/pSegmento2C), new Generalidades.NullableString(/*8*/pSegmento3C),
        //        new Generalidades.NullableString(/*9*/pSegmento4C) };

        //    Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

        //    iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

        //    oiDAAB.eliminar("tesRetProvSegmentoEliminar", parametros);
        //}


        public static Int32 Guardar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, 
            int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, 
            string /*9*/pSegmento4C, long /*10*/ptesMovimientos, int /*11*/pconRenglon, bool /*12*/pTieneAutomatico, 
            string /*13*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N,
                /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C,
                /*10*/ptesMovimientos, /*11*/pconRenglon, /*12*/pTieneAutomatico };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (Int32)oiDAAB.guardar("tesRetProvSegmentoGuardar", parametros);
        }
    }
}
