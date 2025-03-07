using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkInvenSegmentos
    {
        public static stkInvenSegmentosDS Datos(int /*0*/pEmpresa_id, string /*1*/pSegmento_id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_id, /*1*/pSegmento_id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkInvenSegmentosDatos", parametros);

            stkInvenSegmentosDS dsTipado = new stkInvenSegmentosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pEmpresa_id, string /*1*/pSegmento_id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_id, /*1*/pSegmento_id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkInvenSegmentosEliminar", parametros);
        }
        public static int Insertar(int /*0*/pstkInventarios, int /*1*/pEmpresa_Id, string /*2*/pSegmento_Id, int /*3*/pSegmento1N, int /*4*/pSegmento2N, int /*5*/pSegmento3N, int /*6*/pSegmento4N, string /*7*/pSegmento1C, string /*8*/pSegmento2C, string /*9*/pSegmento3C, string /*10*/pSegmento4C, bool /*11*/pAutomatico, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkInventarios, /*1*/pEmpresa_Id, /*2*/pSegmento_Id, /*3*/pSegmento1N, /*4*/pSegmento2N, /*5*/pSegmento3N, /*6*/pSegmento4N, /*7*/pSegmento1C, /*8*/pSegmento2C, /*9*/pSegmento3C, /*10*/pSegmento4C, /*11*/pAutomatico };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("stkInvenSegmentosInsertar", parametros);
        }








    }
}
