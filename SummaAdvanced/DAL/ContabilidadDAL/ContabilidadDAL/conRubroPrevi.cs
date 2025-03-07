using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conRubroPrevi
    {
        public static conRubroPreviDS Datos(string /*0*/pRubroPrevi_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubroPrevi_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conRubroPreviDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            conRubroPreviDS dsTipado = new conRubroPreviDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(string /*0*/pRubroPrevi_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubroPrevi_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conRubroPreviEliminar", parametros);
        }
        public static void Guardar(string /*0*/pRubroPrevi_Id, string /*1*/pDescripcion, int /*2*/pEmpresa_Id, string /*3*/pActivoPasivo, bool /*4*/pCorriente, int /*5*/pOrden, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubroPrevi_Id, /*1*/pDescripcion, /*2*/pEmpresa_Id, /*3*/pActivoPasivo, /*4*/pCorriente, /*5*/pOrden };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conRubroPreviGuardar", parametros);
        }


        public static void EliminarCuerpo(string /*0*/pRubroPrevi_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubroPrevi_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conRubroPreviCtasEliminar", parametros);
        }
        public static void GuardarCuerpo(string /*0*/pRubroPrevi_Id, string /*1*/pCuenta_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubroPrevi_Id, /*1*/pCuenta_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conRubroPreviCtasInsertar", parametros);
        }


    }
}
