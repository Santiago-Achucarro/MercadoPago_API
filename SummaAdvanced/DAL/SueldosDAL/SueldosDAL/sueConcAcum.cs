using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using SueldosCommon;
namespace SueldosDAL
{
    public class sueConcAcum
    {

        public static sueConcAcumDS Datos(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueConcAcumDatos", parametros);

            sueConcAcumDS dsTipado = new sueConcAcumDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(int /*0*/psueConcAcum, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueConcAcum };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueConcAcumEliminar", parametros);
        }

        public static int Guardar(int /*0*/psueConcAcum, int /*1*/pConcepto_Id, long /*2*/pLegajo, DateTime /*3*/pFecha, decimal /*4*/pMontoTope, decimal /*5*/pDescuento, decimal /*6*/pAcumulado, int /*7*/pUsuario_Id, bool /*8*/pAnulado, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueConcAcum, /*1*/pConcepto_Id, /*2*/pLegajo, /*3*/pFecha, /*4*/pMontoTope, /*5*/pDescuento, /*6*/pAcumulado, /*7*/pUsuario_Id, /*8*/pAnulado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("sueConcAcumGuardar", parametros);
        }





    }
}
