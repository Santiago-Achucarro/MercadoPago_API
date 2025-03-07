using System;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genHorariosIngreso
    {
        public static genHorariosIngresoDS Datos(int /*0*/pUsuario_Id, DateTime /*1*/pHora, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id, new Generalidades.NullableDate(/*1*/pHora) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genHorariosIngreso", parametros);

            string[] camposTabla0 = { "HoraDesde", "HoraHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genHorariosIngresoDS dsTipado = new genHorariosIngresoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Guardar(string /*0*/pUsuario_Id, bool /*1*/pLunes, bool /*2*/pMartes, bool /*3*/pMiercoles,
            bool /*4*/pJueves, bool /*5*/pViernes, bool /*6*/pSabado, bool /*7*/pDomingo, bool /*8*/pFestivo,
            string /*9*/pHoraDesde, string /*10*/pHoraHasta, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[]
            {
                /*0*/pUsuario_Id, /*1*/pLunes, /*2*/pMartes, /*3*/pMiercoles, /*4*/pJueves, /*5*/pViernes, /*6*/
                pSabado, /*7*/pDomingo, /*8*/pFestivo, /*9*/pHoraDesde, /*10*/pHoraHasta
            };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genHorariosIngresoGuardar", parametros);
        }

        public static void Eliminar(string /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[]
            {
                /*0*/pUsuario_Id
            };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genHorariosIngresoEliminar", parametros);
        }


    }
}