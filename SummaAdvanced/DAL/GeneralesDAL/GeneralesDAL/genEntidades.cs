using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genEntidades
    {
        public static genEntidadesDS Datos(long /*0*/pgenEntidades, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genEntidadesDatos", parametros);

            genEntidadesDS dsTipado = new genEntidadesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static genEntidadesDS Datos(string /*0*/pCuit, string /*1*/pTipoDoc, string /*2*/pidFiscal, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuit, /*1*/pTipoDoc, /*2*/pidFiscal };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genEntidadesDatosCuit", parametros);

            genEntidadesDS dsTipado = new genEntidadesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pgenEntidades, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genEntidadesEliminar", parametros);
        }
        public static Int64 Guardar(long /*0*/pgenEntidades, DateTime /*1*/pFechaAlta, int /*2*/pUsuario_Id, string /*3*/pCuit,
            string /*4*/pTipoDoc, string /*5*/pidFiscal, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades, /*1*/pFechaAlta, /*2*/pUsuario_Id, /*3*/pCuit,
                /*4*/pTipoDoc, /*5*/pidFiscal };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((Int64)oiDAAB.guardar("genEntidadesGuardar", parametros));
        }
    }
}
