using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SueldosCommon;
using interfaceDAAB;
using System.Data;

namespace SueldosDAL
{
    public class sueConcAcumSegmento
    {
        public static sueConcAcumSegmentoDS Datos(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueConcAcumSegmentoDatos", parametros);

            sueConcAcumSegmentoDS dsTipado = new sueConcAcumSegmentoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, new Generalidades.NullableInt(/*1*/pSegmento1N), new Generalidades.NullableInt(/*2*/pSegmento2N), new Generalidades.NullableInt(/*3*/pSegmento3N), new Generalidades.NullableInt(/*4*/pSegmento4N), new Generalidades.NullableString(/*5*/pSegmento1C), new Generalidades.NullableString(/*6*/pSegmento2C), new Generalidades.NullableString(/*7*/pSegmento3C), new Generalidades.NullableString(/*8*/pSegmento4C), /*9*/pEmpresa_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueConcAcumSegmentoEliminar", parametros);
        }

        public static int Guardar(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, int /*10*/psueConcAcum, bool /*11*/pTieneAutomatico, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id, /*10*/psueConcAcum, /*11*/pTieneAutomatico };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("sueConcAcumSegmentoGuardar", parametros);
        }








    }
}
