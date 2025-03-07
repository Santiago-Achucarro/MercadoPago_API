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
  public class stkDevolucionesClie
    {
        public static stkDevolucionesClieDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pSegmento_IdSal, int /*11*/pSegmento1NSal, int /*12*/pSegmento2NSal, int /*13*/pSegmento3NSal, int /*14*/pSegmento4NSal, string /*15*/pSegmento1CSal, string /*16*/pSegmento2CSal, string /*17*/pSegmento3CSal, string /*18*/pSegmento4CSal, string /*19*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pSegmento_IdSal, /*11*/pSegmento1NSal, /*12*/pSegmento2NSal, /*13*/pSegmento3NSal, /*14*/pSegmento4NSal, /*15*/pSegmento1CSal, /*16*/pSegmento2CSal, /*17*/pSegmento3CSal, /*18*/pSegmento4CSal };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkDevolucionesClieDatos", parametros);

            string[] camposTabla0 = { "DescripcionCausa", "Centro1_Id", "Centro2_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkDevolucionesClieDS dsTipado = new stkDevolucionesClieDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.venMov.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }








        public static void Eliminar(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkDevolucionesClieEliminar", parametros);
        }


        public static void Guardar(long /*0*/pstkMoviCabe, long /*1*/pvenMovimientosFact, long /*2*/pvenMovimientosNC, int /*3*/pRenglon, int /*4*/pRenglonCuerpo, int /*5*/pRenglonNC, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pvenMovimientosFact,new Generalidades.NullableInt64 (/*2*/pvenMovimientosNC), /*3*/pRenglon, /*4*/pRenglonCuerpo, new Generalidades.NullableInt64( /*5*/pRenglonNC) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);
          interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkDevolucionesClieGuardar", parametros);
        }





    }
}
