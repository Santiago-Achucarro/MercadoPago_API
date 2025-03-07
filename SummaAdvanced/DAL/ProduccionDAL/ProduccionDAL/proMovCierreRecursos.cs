using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;


namespace ProduccionDAL
{
    public class proMovCierreRecursos
    {

        public static proMovCierreRecursosDS Datos(long /*0*/pproMovCierreOrden, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proMovCierreRecursosDatos", parametros);

            string[] camposTabla0 = { "SubRecurso_Id", "DescripcionSubRecurso" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            proMovCierreRecursosDS dsTipado = new proMovCierreRecursosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pproMovCierreOrden, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proMovCierreRecursosEliminar", parametros);
        }

        public static void Insertar(long /*0*/pproMovCierreOrden, int /*1*/pRenglon, string /*2*/pRecurso_Id, string /*3*/pSubRecurso_Id, decimal /*4*/pCantidad, decimal /*5*/pCosto, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproMovCierreOrden, /*1*/pRenglon, /*2*/pRecurso_Id, new Generalidades.NullableString(/*3*/pSubRecurso_Id), /*4*/pCantidad, /*5*/pCosto };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proMovCierreRecursosInsertar", parametros);
        }



    }
}
