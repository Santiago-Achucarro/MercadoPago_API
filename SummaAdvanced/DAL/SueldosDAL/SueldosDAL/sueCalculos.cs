using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueCalculos
    {

        public static int ExisteSemana(int /*0*/Anio, int /*3*/Semana, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Anio, /*1*/Semana};

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("sueFormExisteVez", parametros));
        }

        public static decimal Hora(string /*0*/Categoria_Id, DateTime /*1*/Fecha, int /*2*/nImporte, int /*3*/Empresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Categoria_Id, /*1*/Fecha, /*2*/nImporte, /*3*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((decimal)oiDAAB.guardar("sueFormHora", parametros));
        }
        public static decimal IMP(int /*0*/Legajo, DateTime /*1*/Fecha, int /*2*/nImporte, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/Fecha, /*2*/nImporte };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (decimal) oiDAAB.guardar("sueFormIMP", parametros);
        }

        public static decimal COD(int /*0*/Legajo, int /*1*/Concepto, int /*2*/Anio, int /*3*/Mes, int /*4*/Quin, int /*5*/Decena, int /*6*/Semana, int /*7*/Vez, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/Concepto, /*2*/Anio, /*3*/Mes, /*4*/Quin, /*5*/Decena, /*6*/Semana, /*7*/Vez };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (decimal) oiDAAB.guardar("sueFormCOD", parametros);
        }

        public static decimal VAR(int /*0*/nVariable, DateTime /*1*/Fecha, int /*2*/Empresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/nVariable, /*1*/Fecha, /*2*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (decimal) oiDAAB.guardar("sueFormVAR", parametros);
        }

        public static decimal ACUM(int /*0*/Legajo, int /*1*/ConceptoDesde, int /*2*/ConceptoHasta, int /*3*/AnioDesde, int /*4*/MesDesde, int /*5*/AnioHasta, int /*6*/MesHasta, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/ConceptoDesde, /*2*/ConceptoHasta, /*3*/AnioDesde, /*4*/MesDesde, /*5*/AnioHasta, /*6*/MesHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((decimal)oiDAAB.guardar("sueFormACUM", parametros));
        }

        public static decimal Neto(int /*0*/Legajo, int /*1*/Anio, int /*2*/Mes, int /*3*/Quin, int /*4*/Decena, int /*5*/Semana, int /*6*/Vez, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/Anio, /*2*/Mes, /*3*/Quin, /*4*/Decena, /*5*/Semana, /*6*/Vez };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (decimal) oiDAAB.guardar("sueFormNETO", parametros);
        }
        public static decimal SCANT(int /*0*/Legajo, int /*1*/ConceptoDesde, int /*2*/ConceptoHasta, int /*3*/AnioDesde, int /*4*/MesDesde, int /*5*/AnioHasta, int /*6*/MesHasta, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/ConceptoDesde, /*2*/ConceptoHasta, /*3*/AnioDesde, /*4*/MesDesde, /*5*/AnioHasta, /*6*/MesHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (decimal) oiDAAB.guardar("sueFormSCANT", parametros);
        }


        public static decimal SCANTTERMI(int /*0*/Legajo, int /*1*/ConceptoDesde, int /*2*/ConceptoHasta, int /*3*/AnioDesde, int /*4*/MesDesde, int /*5*/AnioHasta, int /*6*/MesHasta, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/ConceptoDesde, /*2*/ConceptoHasta, /*3*/AnioDesde, /*4*/MesDesde, /*5*/AnioHasta, /*6*/MesHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (decimal)oiDAAB.guardar("sueFormSCANTERMI", parametros);
        }

        public static decimal CANT(int /*0*/Legajo, int /*1*/ConceptoDesde, int /*2*/ConceptoHasta, int /*3*/Anio, int /*4*/Mes, int /*5*/Quin, int /*6*/Decena, int /*7*/Semana, int /*8*/Vez, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/ConceptoDesde, /*2*/ConceptoHasta, /*3*/Anio, /*4*/Mes, /*5*/Quin, /*6*/Decena, /*7*/Semana, /*8*/Vez };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

             return (decimal) oiDAAB.guardar("sueFormCANT", parametros);
        }

        public static decimal SDATO(int /*0*/Legajo, int /*1*/ConceptoDesde, int /*2*/ConceptoHasta, int /*3*/Anio, int /*4*/Mes, int /*5*/Quin, int /*6*/Decena, int /*7*/Semana, int /*8*/Vez, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/ConceptoDesde, /*2*/ConceptoHasta, /*3*/Anio, /*4*/Mes, /*5*/Quin, /*6*/Decena, /*7*/Semana, /*8*/Vez };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (decimal) oiDAAB.guardar("sueFormSDATO", parametros);
        }

        public static decimal SUMA(int /*0*/Legajo, int /*1*/ConceptoDesde, int /*2*/ConceptoHasta, int /*3*/Anio, int /*4*/Mes, int /*5*/Quin, int /*6*/Decena, int /*7*/Semana, int /*8*/Vez, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/ConceptoDesde, /*2*/ConceptoHasta, /*3*/Anio, /*4*/Mes, /*5*/Quin, /*6*/Decena, /*7*/Semana, /*8*/Vez };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (decimal) oiDAAB.guardar("sueFormSUMA", parametros);
        }

        public static decimal SUMAP(int /*0*/Legajo, int /*1*/ConceptoDesde, int /*2*/ConceptoHasta, int /*3*/Anio, int /*4*/Mes, int /*5*/Quin, int /*6*/Decena, int /*7*/Semana, int /*8*/Vez, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/ConceptoDesde, /*2*/ConceptoHasta, /*3*/Anio, /*4*/Mes, /*5*/Quin, /*6*/Decena, /*7*/Semana, /*8*/Vez };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (decimal)oiDAAB.guardar("sueFormSUMAP", parametros);
        }

        public static decimal SUMSGN(int /*0*/Legajo, int /*1*/ConceptoDesde, int /*2*/ConceptoHasta, int /*3*/Anio, int /*4*/Mes, int /*5*/Quin, int /*6*/Decena, int /*7*/Semana, int /*8*/Vez, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/ConceptoDesde, /*2*/ConceptoHasta, /*3*/Anio, /*4*/Mes, /*5*/Quin, /*6*/Decena, /*7*/Semana, /*8*/Vez };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (decimal)oiDAAB.guardar("sueFormSUMSGN", parametros);
        }

        public static decimal DATO(int /*0*/Legajo, int /*1*/Concepto, int /*2*/Anio, int /*3*/Mes, int /*4*/Quin, int /*5*/Decena, int /*6*/Semana, int /*7*/Vez, string /*8*/ pAuxiliar, out decimal Dato2 )
        {
            Dato2 = 0;
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/Concepto, /*2*/Anio, /*3*/Mes, /*4*/Quin, /*5*/Decena, /*6*/Semana, /*7*/Vez };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);
            DataSet lDs = oiDAAB.getObject("sueFormDATO", parametros);
            // viene Dato y Dato2
            decimal lRet = Convert.ToDecimal(lDs.Tables[0].Rows[0][0]);
            Dato2 = Convert.ToDecimal(lDs.Tables[0].Rows[0][1]);
            return lRet;
        }



        public static decimal SUMAA(int /*0*/Legajo, int /*1*/ConceptoDesde, int /*2*/ConceptoHasta, int /*3*/Anio, int /*4*/Mes, int /*5*/Quin, int /*6*/Decena, int /*7*/Semana, int /*8*/Vez, string /*9*/Propiedad, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/ConceptoDesde, /*2*/ConceptoHasta, /*3*/Anio, /*4*/Mes, /*5*/Quin, /*6*/Decena, /*7*/Semana, /*8*/Vez, /*9*/Propiedad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((decimal)oiDAAB.guardar("sueFormSUMAA", parametros));
        }

        public static decimal SUMAAFPago(int /*0*/Legajo, int /*1*/ConceptoDesde, int /*2*/ConceptoHasta, int /*3*/Anio, int /*4*/Mes, int /*5*/Quin, int /*6*/Decena, int /*7*/Semana, int /*8*/Vez, string /*9*/Propiedad, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/ConceptoDesde, /*2*/ConceptoHasta, /*3*/Anio, /*4*/Mes, /*5*/Quin, /*6*/Decena, /*7*/Semana, /*8*/Vez, /*9*/Propiedad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((decimal)oiDAAB.guardar("sueFormSUMAAFPago", parametros));
        }

        public static sueFormTablaDS Tabla(int /*0*/Tabla_Id, decimal /*1*/Valor, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Tabla_Id, /*1*/Valor };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueFormTabla", parametros);

            sueFormTablaDS dsTipado = new sueFormTablaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static sueFormTablaGanDS TablaGan(int /*0*/Tabla_Id, decimal /*1*/Valor, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Tabla_Id, /*1*/Valor };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueFormTablaGan", parametros);

            sueFormTablaGanDS dsTipado = new sueFormTablaGanDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static sueFormCONCACUMDS CONCACUM(int /*0*/Concepto_Id, int /*1*/Legajo, DateTime /*2*/Fecha, int /*3*/Empresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Concepto_Id, /*1*/Legajo, /*2*/Fecha, /*3*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueFormCONCACUM", parametros);

            sueFormCONCACUMDS dsTipado = new sueFormCONCACUMDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static sueFormEnvacDS ENVAC(int /*0*/pLegajo, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pFechaDesde, /*2*/pFechaHasta };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueFormEnvac", parametros);

            sueFormEnvacDS dsTipado = new sueFormEnvacDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static sueFormGananciasDS GanCony(int /*0*/pLegajo, string /*1*/ pAuxiliar)

        {
            Object[] parametros = new Object[] {/*0*/pLegajo };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueFormGanCony", parametros);

            string[] camposTabla0 = { "FechaBaja" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueFormGananciasDS dsTipado = new sueFormGananciasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static sueFormGananciasDS GanOtro(int /*0*/pLegajo, string /*1*/ pAuxiliar)

        {
            Object[] parametros = new Object[] {/*0*/pLegajo };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueFormGanOtro", parametros);

            string[] camposTabla0 = { "FechaBaja" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueFormGananciasDS dsTipado = new sueFormGananciasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static sueFormGanHijoDS GanHijo(int /*0*/pLegajo, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueFormGanHijo", parametros);

            string[] camposTabla0 = { "FechaBaja" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueFormGanHijoDS dsTipado = new sueFormGanHijoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static decimal DVAC(int /*0*/Legajo, DateTime /*1*/FechaDesde, DateTime /*2*/FechaHasta, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/FechaDesde, /*2*/FechaHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (decimal)oiDAAB.guardar("sueFormDVac", parametros);
        }

        public static decimal SUMH(int /*0*/Legajo, int /*1*/ConceptoDesde, int /*2*/ConceptoHasta, int /*3*/Anio, int /*4*/Mes, int /*5*/Quin, int /*6*/Decena, int /*7*/Semana, int /*8*/Vez, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Legajo, /*1*/ConceptoDesde, /*2*/ConceptoHasta, /*3*/Anio, /*4*/Mes, /*5*/Quin, /*6*/Decena, /*7*/Semana, /*8*/Vez };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (decimal)oiDAAB.guardar("sueFormSUMH", parametros);
        }
    }
}

