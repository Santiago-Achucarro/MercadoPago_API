using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContabilidadCommon;
using interfaceDAAB;
using System.Data;

namespace ContabilidadDAL
{
    public class conAsieCierre
    {


        public static conAsieCierreDS DatosCierre(int /*0*/Empresa, short /*1*/Ejercicio, string /*2*/CtaResEjer, string /*3*/CtaResAcum, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa, /*1*/Ejercicio, /*2*/CtaResEjer, /*3*/CtaResAcum };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conAsieCierreDATOS", parametros);

            string[] camposTabla0 = { "Ejercicio", "CtaResEjer", "CtaResAcum" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            conAsieCierreDS dsTipado = new conAsieCierreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static conAsieCierrePatDS DatosCierrePat(int /*0*/Empresa, short /*1*/Ejercicio, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa, /*1*/Ejercicio };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conAsieCierrePatDATOS", parametros);

            string[] camposTabla0 = { "Ejercicio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Monto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conAsieCierrePatDS dsTipado = new conAsieCierrePatDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static conAsieCierreResDS DatosCierreRes(int /*0*/Empresa, short /*1*/Ejercicio, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa, /*1*/Ejercicio };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conAsieCierreResDATOS", parametros);

            string[] camposTabla0 = { "Ejercicio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Monto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conAsieCierreResDS dsTipado = new conAsieCierreResDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static conAsieApeDS DatosApe(int /*0*/Empresa, short /*1*/Ejercicio, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa, /*1*/Ejercicio };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conAsieApeDATOS", parametros);

            string[] camposTabla0 = { "Ejercicio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            conAsieApeDS dsTipado = new conAsieApeDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





    }
}
