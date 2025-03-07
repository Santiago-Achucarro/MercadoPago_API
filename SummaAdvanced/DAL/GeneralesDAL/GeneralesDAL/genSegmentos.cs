using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genSegmentos
    {
        public static genSegmentosDS Datos(string /*0*/pSegmento_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genSegmentosDatos", parametros);

            string[] camposTabla0 = { "Origen1N", "DescripcionSegmentosOrigenes1N", "Origen2N", "DescripcionSegmentosOrigenes2N", "Origen3N", "DescripcionSegmentosOrigenes3N", "Origen4N", "DescripcionSegmentosOrigenes4N", "Origen1C", "DescripcionSegmentosOrigenes1C", "Origen2C", "DescripcionSegmentosOrigenes2C", "Origen3C", "DescripcionSegmentosOrigenes3C", "Origen4C", "DescripcionSegmentosOrigenes4C", "Nombre1N", "Nombre2N", "Nombre3N", "Nombre4N", "Nombre1C", "Nombre2C", "Nombre3C", "Nombre4C" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genSegmentosDS dsTipado = new genSegmentosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pSegmento_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { pSegmento_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genSegmentosEliminar", parametros);
        }

        public static int Guardar(string /*0*/pSegmento_Id, string /*1*/pSegmento_Id_Nuevo, string /*2*/pDescripcion, int /*3*/pDigitos1N, int /*4*/pDigitos2N, int /*5*/pDigitos3N, int /*6*/pDigitos4N, bool /*7*/pTieneColumnaAutomatica, int /*8*/pDigitos1C, int /*9*/pDigitos2C, int /*10*/pDigitos3C, int /*11*/pDigitos4C, short /*12*/pOrigen1N, short /*13*/pOrigen2N, short /*14*/pOrigen3N, short /*15*/pOrigen4N, short /*16*/pOrigen1C, short /*17*/pOrigen2C, short /*18*/pOrigen3C, short /*19*/pOrigen4C, short /*20*/pOrden1N, short /*21*/pOrden2N, short /*22*/pOrden3N, short /*23*/pOrden4N, short /*24*/pOrden1C, short /*25*/pOrden2C, short /*26*/pOrden3C, short /*27*/pOrden4C, bool /*28*/pHabilitaEdicion, string /*29*/pTamanioVariable, bool /*30*/pInactivo, int /*31*/pUsuario_Id, bool /*32*/pPosteado, bool /*33*/pEsSueldos, bool /*34*/pEmpiezaEnUno, string /*35*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento_Id_Nuevo, /*2*/pDescripcion, /*3*/pDigitos1N, /*4*/pDigitos2N, /*5*/pDigitos3N, /*6*/pDigitos4N, /*7*/pTieneColumnaAutomatica, /*8*/pDigitos1C, /*9*/pDigitos2C, /*10*/pDigitos3C, /*11*/pDigitos4C, /*12*/pOrigen1N, /*13*/pOrigen2N, /*14*/pOrigen3N, /*15*/pOrigen4N, /*16*/pOrigen1C, /*17*/pOrigen2C, /*18*/pOrigen3C, /*19*/pOrigen4C, /*20*/pOrden1N, /*21*/pOrden2N, /*22*/pOrden3N, /*23*/pOrden4N, /*24*/pOrden1C, /*25*/pOrden2C, /*26*/pOrden3C, /*27*/pOrden4C, /*28*/pHabilitaEdicion, /*29*/pTamanioVariable, /*30*/pInactivo, /*31*/pUsuario_Id, /*32*/pPosteado, /*33*/pEsSueldos, /*34*/pEmpiezaEnUno };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("genSegmentosGuardar", parametros));
        }




        public static genSegmentoStrDS SegmentoSTR(string /*0*/Segmento_Id, string /*1*/Segmento1C, string /*2*/Segmento2C, string /*3*/Segmento3C, string /*4*/Segmento4C, int /*5*/Segmento1N, int /*6*/Segmento2N, int /*7*/Segmento3N, int /*8*/Segmento4N, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Segmento_Id, /*1*/Segmento1C, /*2*/Segmento2C, /*3*/Segmento3C, /*4*/Segmento4C, /*5*/Segmento1N, /*6*/Segmento2N, /*7*/Segmento3N, /*8*/Segmento4N };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genSegmentoStr", parametros);

            string[] camposTabla0 = { "SegmentoSTR", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genSegmentoStrDS dsTipado = new genSegmentoStrDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
