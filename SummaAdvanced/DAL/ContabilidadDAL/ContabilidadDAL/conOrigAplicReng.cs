using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conOrigAplicReng
    {
        public static conOrigAplicRengDS Datos(string /*0*/pGrupoOAF_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupoOAF_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conOrigAplicRengDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            conOrigAplicRengDS dsTipado = new conOrigAplicRengDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(string /*0*/pGrupoOaf_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupoOaf_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conOrigAplicRengEliminar", parametros);
        }
        public static void Guardar(string /*0*/pGrupoOAF_Id, int /*1*/pEmpresa_Id, int /*2*/pDestino, int /*3*/pOrigen, string /*4*/pDescripcion, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupoOAF_Id, /*1*/pEmpresa_Id, /*2*/pDestino, /*3*/pOrigen, /*4*/pDescripcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conOrigAplicRengGuardar", parametros);
        }
        public static void GuardarCuerpo(string /*0*/pGrupoOAF_Id, string /*1*/pCuenta_Id, string /*2*/pNetoDebeHaber, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupoOAF_Id, /*1*/pCuenta_Id, /*2*/pNetoDebeHaber };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conOrigAplicCtasInsertar", parametros);
        }
        public static void EliminarCuerpo(string /*0*/pGrupoOAF_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupoOAF_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conOrigAplicCtasEliminar", parametros);
        }


    }
}
