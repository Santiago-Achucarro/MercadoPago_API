using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesSolicitantes
    {
        public static tesSolicitantesDS Datos(string /*0*/pSolicitante_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSolicitante_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesSolicitantesDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Banco_Id", "DescripcionBancos", "Cuenta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesSolicitantesDS dsTipado = new tesSolicitantesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pSolicitante_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSolicitante_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesSolicitantesEliminar", parametros);
        }

        public static void Guardar(long /*0*/pgenEntidades, string /*1*/pSolicitante_Id, string /*2*/pSolicitante_Id_Nueva, int /*3*/pEmpresa_Id, string /*4*/pNombre, bool /*5*/pInactivo, bool /*6*/pPosteado, string /*7*/pBanco_Id, string /*8*/pCuenta, int /*9*/pUsuario_Id, DateTime /*10*/pFechaCarga, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades, /*1*/pSolicitante_Id, /*2*/pSolicitante_Id_Nueva, new Generalidades.NullableInt(/*3*/pEmpresa_Id), /*4*/pNombre, /*5*/pInactivo, /*6*/pPosteado, new Generalidades.NullableString(/*7*/pBanco_Id), new Generalidades.NullableString(/*8*/pCuenta), /*9*/pUsuario_Id, /*10*/pFechaCarga };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesSolicitantesGuardar", parametros);
        }


        public static tesSolicitantesDS DatosInt(Int64 /*0*/pSolicitante_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSolicitante_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesSolicitantesDatosId", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Banco_Id", "DescripcionBancos", "Cuenta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesSolicitantesDS dsTipado = new tesSolicitantesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
