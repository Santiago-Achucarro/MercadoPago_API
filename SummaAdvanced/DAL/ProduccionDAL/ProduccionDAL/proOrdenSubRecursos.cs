using interfaceDAAB;
using ProduccionCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProduccionDAL
{
    public class proOrdenSubRecursos
    {
        public static proOrdenSubRecursoDS Datos(int /*0*/pproOrden, int /*1*/pRenglon, int /*2*/pSubRecurso_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproOrden, /*1*/pRenglon, /*2*/pSubRecurso_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proOrdenSubRecursoDatos", parametros);

            proOrdenSubRecursoDS dsTipado = new proOrdenSubRecursoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(int /*0*/pproOrden, int /*1*/pRenglon, string /*2*/pSubRecurso_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproOrden, new Generalidades.NullableInt(/*1*/pRenglon), new Generalidades.NullableString(/*2*/pSubRecurso_Id) };
            
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proOrdenSubRecursoEliminar", parametros);
        }
        public static void Guardar(int /*0*/pproOrden, int /*1*/pRenglon, string /*2*/pSubRecurso_Id, decimal /*3*/pCantidad, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproOrden, /*1*/pRenglon, /*2*/pSubRecurso_Id, /*3*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proOrdenSubRecursoGuardar", parametros);
        }





    }

}
