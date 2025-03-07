using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conAsientosContInver
    {

        public static conAsientosInverDS Datos(int /*0*/pEmpresa_id, string /*1*/pSegmento_id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pSegmento_id_Inver, int /*11*/pSegmento1N_Inver, int /*12*/pSegmento2N_Inver, int /*13*/pSegmento3N_Inver, int /*14*/pSegmento4N_Inver, string /*15*/pSegmento1C_Inver, string /*16*/pSegmento2C_Inver, string /*17*/pSegmento3C_Inver, string /*18*/pSegmento4C_Inver, string /*19*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_id, /*1*/pSegmento_id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pSegmento_id_Inver, /*11*/pSegmento1N_Inver, /*12*/pSegmento2N_Inver, /*13*/pSegmento3N_Inver, /*14*/pSegmento4N_Inver, /*15*/pSegmento1C_Inver, /*16*/pSegmento2C_Inver, /*17*/pSegmento3C_Inver, /*18*/pSegmento4C_Inver };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conAsientosInverDatos", parametros);

            string[] camposTabla0 = { "Moneda_Id", "DescripcionMonedas", "Observaciones", "TotalDebe", "TotalHaber", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "ReferenciaT", "Referencia1", "Referencia2", "Referencia3", "Referencia4", "Referencia5", "Base_Id", "DescripcionBaseDistri" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            conAsientosInverDS dsTipado = new conAsientosInverDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.SegmentoOriginal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Guardar(long /*0*/pAsiento_Id, long /*1*/pAsiento_Id_Inver, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pAsiento_Id_Inver };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conAsientosInverGuardar", parametros);
        }
        public static void Eliminar(long /*0*/pAsiento_Id, long /*1*/pAsiento_Id_Inver, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pAsiento_Id_Inver };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conAsientosInverEliminar", parametros);
        }


    }
}
