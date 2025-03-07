using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueVariables
    {
        public static sueVariableDS Datos(int /*0*/pLegajo, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueVariableDatos", parametros);

            string[] camposTabla1 = { "Grupo_Id", "DescripcionGrupos", "Concepto_Id", "DescripcionConceptos", "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueVariableDS dsTipado = new sueVariableDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pLegajo, int /*1*/pGrupo_Id, int /*2*/pConcepto_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, new Generalidades.NullableInt(/*1*/pGrupo_Id), new Generalidades.NullableInt(/*2*/pConcepto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueVariableEliminar", parametros);
        }

        public static void Guardar(int /*0*/pLegajo, int /*1*/pGrupo_Id, int /*2*/pConcepto_Id, int /*3*/pUsuario_Id, DateTime /*4*/pFechaRegistro, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pGrupo_Id, /*2*/pConcepto_Id, new Generalidades.NullableInt(/*3*/pUsuario_Id), /*4*/pFechaRegistro };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueVariableGuardar", parametros);
        }

        public static sueVariableGrupoDS GrupoDatos(int /*0*/Legajo, int /*1*/Grupo_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/Grupo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueVariableGrupoDatos", parametros);

            string[] camposTabla0 = { "Legajo", "Grupo_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueVariableGrupoDS dsTipado = new sueVariableGrupoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Conceptos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





    }
}
