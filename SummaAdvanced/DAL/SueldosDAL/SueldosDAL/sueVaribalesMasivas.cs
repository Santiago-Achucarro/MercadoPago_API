using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueVaribalesMasivas
    {
        public static sueVariablesMasivoDS DatosMasivo(int /*0*/pLegajoDesde, int /*1*/pLegajoHasta, int /*2*/pConceptoDesde, int /*3*/pConceptoHasta, int /*4*/pGrupoFuente, int /*5*/pGrupoDestino, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajoDesde, /*1*/pLegajoHasta, /*2*/pConceptoDesde, /*3*/pConceptoHasta, new Generalidades.NullableInt(/*4*/pGrupoFuente), /*5*/pGrupoDestino };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueVariablesMasivoDatos", parametros);

            string[] camposTabla0 = { "Legajo_Desde", "Legajo_Hasta", "Concepto_Desde", "Concepto_Hasta", "Grupo_Fuente", "Grupo_Destino" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueVariablesMasivoDS dsTipado = new sueVariablesMasivoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static sueVariableCopiarDS DatosCopiar(int /*0*/pLegajoOrigen, int /*1*/pLegajoDesde, int /*2*/pLegajoHasta, int /*3*/pConceptoDesde, int /*4*/pConceptoHasta, int /*5*/pGrupoDesde, int /*6*/pGrupoHasta, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajoOrigen, /*1*/pLegajoDesde, /*2*/pLegajoHasta, /*3*/pConceptoDesde, /*4*/pConceptoHasta, /*5*/pGrupoDesde, /*6*/pGrupoHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueVariableCopiar", parametros);

            string[] camposTabla0 = { "Legajo_Origen", "Legajo_Desde", "Legajo_Hasta", "Concepto_Desde", "Concepto_Hasta", "Grupo_Desde", "Grupo_Hasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueVariableCopiarDS dsTipado = new sueVariableCopiarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Copiar(int /*0*/pLegajoOrigen, int /*1*/pLegajoDesde, int /*2*/pLegajoHasta, int /*3*/pConceptoDesde, int /*4*/pConceptoHasta, int /*5*/pGrupoDesde, int /*6*/pGrupoHasta, long /*7*/pUsuario_Id, int /*8*/pEmpresa_Id, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajoOrigen, /*1*/pLegajoDesde, /*2*/pLegajoHasta, /*3*/pConceptoDesde, /*4*/pConceptoHasta, /*5*/pGrupoDesde, /*6*/pGrupoHasta, /*7*/pUsuario_Id, /*8*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueVariableCopiarGuardar", parametros);
        }



        public static void GuardarMasivo(int /*0*/pLegajoDesde, int /*1*/pLegajoHasta, int /*2*/pConceptoDesde, int /*3*/pConceptoHasta, int /*4*/pGrupoFuente, int /*5*/pGrupoDestino, long /*6*/pUsuario_Id, int /*7*/pEmpresa_Id, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajoDesde, /*1*/pLegajoHasta, /*2*/pConceptoDesde, /*3*/pConceptoHasta, new Generalidades.NullableInt(/*4*/pGrupoFuente), /*5*/pGrupoDestino, /*6*/pUsuario_Id, /*7*/pEmpresa_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueVariablesMasivoGuardar", parametros);
        }


        public static void Eliminar(int /*0*/pLegajoDesde, int /*1*/pLegajoHasta, int /*2*/pConceptoDesde, int /*3*/pConceptoHasta, int /*4*/pGrupoDesde, int /*5*/pGrupoHasta, int /*6*/pEmpresa_Id, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajoDesde, /*1*/pLegajoHasta, /*2*/pConceptoDesde, /*3*/pConceptoHasta, /*4*/pGrupoDesde, /*5*/pGrupoHasta, /*6*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueVariablesMasivoEliminar", parametros);
        }



        public static sueVariablesMasivoEliminarDS Datos(int /*0*/pLegajoDesde, int /*1*/pLegajoHasta, int /*2*/pConceptoDesde, int /*3*/pConceptoHasta, int /*4*/pGrupoDesde, int /*5*/pGrupoHasta, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajoDesde, /*1*/pLegajoHasta, /*2*/pConceptoDesde, /*3*/pConceptoHasta, /*4*/pGrupoDesde, /*5*/pGrupoHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueVariablesMasivoEliminarDatos", parametros);

            string[] camposTabla0 = { "Legajo_Desde", "Legajo_Hasta", "Concepto_Desde", "Concepto_Hasta", "Grupo_Desde", "Grupo_Hasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueVariablesMasivoEliminarDS dsTipado = new sueVariablesMasivoEliminarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
