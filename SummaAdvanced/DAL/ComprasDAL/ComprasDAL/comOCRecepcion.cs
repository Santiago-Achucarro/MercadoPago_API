using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasCommon;
using interfaceDAAB;
using System.Data;

namespace ComprasDAL
{
    
    public class comOCRecepcion
    {
        public static comOcRecepcionDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pSegmento_Id_OC, int /*11*/pSegmento1N_OC, int /*12*/pSegmento2N_OC, int /*13*/pSegmento3N_OC, int /*14*/pSegmento4N_OC, string /*15*/pSegmento1C_OC, string /*16*/pSegmento2C_OC, string /*17*/pSegmento3C_OC, string /*18*/pSegmento4C_OC, string /*19*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pSegmento_Id_OC, /*11*/pSegmento1N_OC, /*12*/pSegmento2N_OC, /*13*/pSegmento3N_OC, /*14*/pSegmento4N_OC, /*15*/pSegmento1C_OC, /*16*/pSegmento2C_OC, /*17*/pSegmento3C_OC, /*18*/pSegmento4C_OC };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOcRecepcionDatos", parametros);

            string[] camposTabla0 = { "Moneda_Id", "DescripcionMonedas", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "CantidadPendiente", "Centro1_id", "Centro2_id", "CantidadForm" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            comOcRecepcionDS dsTipado = new comOcRecepcionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.OrdenCompra.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static comOcReveRecepcionDS AntiDatos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pSegmento_Id_RE, int /*11*/pSegmento1N_RE, int /*12*/pSegmento2N_RE, int /*13*/pSegmento3N_RE, int /*14*/pSegmento4N_RE, string /*15*/pSegmento1C_RE, string /*16*/pSegmento2C_RE, string /*17*/pSegmento3C_RE, string /*18*/pSegmento4C_RE, string /*19*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pSegmento_Id_RE, /*11*/pSegmento1N_RE, /*12*/pSegmento2N_RE, /*13*/pSegmento3N_RE, /*14*/pSegmento4N_RE, /*15*/pSegmento1C_RE, /*16*/pSegmento2C_RE, /*17*/pSegmento3C_RE, /*18*/pSegmento4C_RE };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOcReveRecepcionDatos", parametros);

            string[] camposTabla0 = { "Moneda_Id", "DescripcionMonedas", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "Centro1_id", "Centro2_id", "CantidadForm", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            comOcReveRecepcionDS dsTipado = new comOcReveRecepcionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Recepcion.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }







    }
}
