using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SueldosCommon;
namespace SueldosDAL
{
    public class sueVezActiva
    {

        public static sueVezActivaDS Datos(int /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueVezActivaDatos", parametros);

            sueVezActivaDS dsTipado = new sueVezActivaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(int /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pEmpresa_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueVezActivaEliminar", parametros);
        }

        public static void Guardar(int /*0*/pEmpresa_Id, int /*1*/pAnio, int /*2*/pMes, int /*3*/pQuin, int /*4*/pDecena, int /*5*/pSemana, int /*6*/pVez, int /*7*/pGrupo_Id, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pAnio, /*2*/pMes, /*3*/pQuin, /*4*/pDecena, /*5*/pSemana, /*6*/pVez, /*7*/pGrupo_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueVezActivaGuardar", parametros);
        }





    }
}
