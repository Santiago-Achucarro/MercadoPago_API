using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genTareasProgramadas
    {

		public static genTareasProgramadasDS Datos(string /*0*/pTareaProgramada_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("genTareasProgramadasDatos", parametros);

			string[] camposTabla0 = { "FechaFin", "HoraFin", "Empresa_Id", "PTodasEmpresas" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla10 = { "Valor" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

			genTareasProgramadasDS dsTipado = new genTareasProgramadasDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.ConRepeticion.TableName, dsTipado.Diaria.TableName, 
									dsTipado.Semanal.TableName, dsTipado.SemanalDias.TableName, 
									dsTipado.Mensual.TableName, dsTipado.MensualMeses.TableName, 
									dsTipado.MensualXDia.TableName, dsTipado.MensualXSemanas.TableName, 
									dsTipado.MensualXDiaSemana.TableName, dsTipado.Parametros.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(string /*0*/pTareaProgramada_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pTareaProgramada_Id) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genTareasProgramadasEliminar", parametros);
		}

		public static int Guardar(string /*0*/pTareaProgramada_Id, string /*1*/pTareaProgramada_Id_Nuevo, string /*2*/pDescripcion, string /*3*/pTarea_Id, DateTime /*4*/pFechaInicio, string /*5*/pHoraInicio, DateTime /*6*/pFechaFin, string /*7*/pHoraFin, string /*8*/pTipoEjecucionTarea_Id, int /*9*/pEmpresa_Id, bool /*10*/pInactivo, int /*11*/pUsuario_Id, bool /*12*/pPosteado, string /*13*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id, /*1*/pTareaProgramada_Id_Nuevo, /*2*/pDescripcion, /*3*/pTarea_Id, /*4*/pFechaInicio, /*5*/pHoraInicio, new Generalidades.NullableDate(/*6*/pFechaFin), new Generalidades.NullableString(/*7*/pHoraFin), /*8*/pTipoEjecucionTarea_Id, new Generalidades.NullableInt(/*9*/pEmpresa_Id), /*10*/pInactivo, /*11*/pUsuario_Id, /*12*/pPosteado };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);
			return (int)oiDAAB.guardar("genTareasProgramadasGuardar", parametros);
		}


		public static void TareasProgSemanalEliminar(string /*0*/pTareaProgramada_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genTareasProgSemanalesEliminar", parametros);
		}

		public static void TareasProgSemanalGuardar(int /*0*/pTareaProgramada_Id, int /*1*/pValor, bool /*2*/pLunes, bool /*3*/pMartes, bool /*4*/pMiercoles, bool /*5*/pJueves, bool /*6*/pViernes, bool /*7*/pSabado, bool /*8*/pDomingo, string /*9*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id, /*1*/pValor, /*2*/pLunes, /*3*/pMartes, /*4*/pMiercoles, /*5*/pJueves, /*6*/pViernes, /*7*/pSabado, /*8*/pDomingo };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("genTareasProgSemanalesGuardar", parametros);
		}

		public static void TareasProgConRepeticionEliminar(string /*0*/pTareaProgramada_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genTareasProgConRepeticionEliminar", parametros);
		}

		public static void TareasProgConRepeticionGuardar(int /*0*/pTareaProgramada_Id, int /*1*/pValor, string /*2*/pUnidadMedida, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id, /*1*/pValor, /*2*/pUnidadMedida };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("genTareasProgConRepeticionGuardar", parametros);
		}

		public static void TareasProgDiariaEliminar(string /*0*/pTareaProgramada_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genTareasProgDiariasEliminar", parametros);
		}

		public static void TareasProgDiariaGuardar(int /*0*/pTareaProgramada_Id, int /*1*/pValor, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id, /*1*/pValor };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("genTareasProgDiariasGuardar", parametros);
		}

		public static void TareasProgMensualEliminar(string /*0*/pTareaProgramada_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genTareasProgMensualesEliminar", parametros);
		}

		public static void TareasProgMensualGuardar(int /*0*/pTareaProgramada_Id, bool /*1*/pEnero, bool /*2*/pFebrero, bool /*3*/pMarzo, bool /*4*/pAbril, bool /*5*/pMayo, bool /*6*/pJunio, bool /*7*/pJulio, bool /*8*/pAgosto, bool /*9*/pSeptiembre, bool /*10*/pOctubre, bool /*11*/pNoviembre, bool /*12*/pDiciembre, string /*13*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id, /*1*/pEnero, /*2*/pFebrero, /*3*/pMarzo, /*4*/pAbril, /*5*/pMayo, /*6*/pJunio, /*7*/pJulio, /*8*/pAgosto, /*9*/pSeptiembre, /*10*/pOctubre, /*11*/pNoviembre, /*12*/pDiciembre };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("genTareasProgMensualesGuardar", parametros);
		}


		public static void TareasProgMensualXDiaEliminar(string /*0*/pTareaProgramada_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genTareasProgMensualesXDiaEliminar", parametros);
		}

		public static void TareasProgMensualXDiaGuardar(int /*0*/pTareaProgramada_Id, bool /*1*/pDia_1, bool /*2*/pDia_2, bool /*3*/pDia_3, bool /*4*/pDia_4, bool /*5*/pDia_5, bool /*6*/pDia_6, bool /*7*/pDia_7, bool /*8*/pDia_8, bool /*9*/pDia_9, bool /*10*/pDia_10, bool /*11*/pDia_11, bool /*12*/pDia_12, bool /*13*/pDia_13, bool /*14*/pDia_14, bool /*15*/pDia_15, bool /*16*/pDia_16, bool /*17*/pDia_17, bool /*18*/pDia_18, bool /*19*/pDia_19, bool /*20*/pDia_20, bool /*21*/pDia_21, bool /*22*/pDia_22, bool /*23*/pDia_23, bool /*24*/pDia_24, bool /*25*/pDia_25, bool /*26*/pDia_26, bool /*27*/pDia_27, bool /*28*/pDia_28, bool /*29*/pDia_29, bool /*30*/pDia_30, bool /*31*/pDia_31, bool /*32*/pUltimo, string /*33*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id, /*1*/pDia_1, /*2*/pDia_2, /*3*/pDia_3, /*4*/pDia_4, /*5*/pDia_5, /*6*/pDia_6, /*7*/pDia_7, /*8*/pDia_8, /*9*/pDia_9, /*10*/pDia_10, /*11*/pDia_11, /*12*/pDia_12, /*13*/pDia_13, /*14*/pDia_14, /*15*/pDia_15, /*16*/pDia_16, /*17*/pDia_17, /*18*/pDia_18, /*19*/pDia_19, /*20*/pDia_20, /*21*/pDia_21, /*22*/pDia_22, /*23*/pDia_23, /*24*/pDia_24, /*25*/pDia_25, /*26*/pDia_26, /*27*/pDia_27, /*28*/pDia_28, /*29*/pDia_29, /*30*/pDia_30, /*31*/pDia_31, /*32*/pUltimo };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("genTareasProgMensualesXDiaGuardar", parametros);
		}

		public static void TareasProgMensualXDiaSemanaEliminar(string /*0*/pTareaProgramada_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genTareasProgMensualesXDiaSemanaEliminar", parametros);
		}


		public static void TareasProgMensualXDiaSemanaGuardar(int /*0*/pTareaProgramada_Id, bool /*1*/pPrimero, bool /*2*/pSegundo, bool /*3*/pTercero, bool /*4*/pCuarto, bool /*5*/pUltimo, bool /*6*/pLunes, bool /*7*/pMartes, bool /*8*/pMiercoles, bool /*9*/pJueves, bool /*10*/pViernes, bool /*11*/pSabado, bool /*12*/pDomingo, string /*13*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id, /*1*/pPrimero, /*2*/pSegundo, /*3*/pTercero, /*4*/pCuarto, /*5*/pUltimo, /*6*/pLunes, /*7*/pMartes, /*8*/pMiercoles, /*9*/pJueves, /*10*/pViernes, /*11*/pSabado, /*12*/pDomingo };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("genTareasProgMensualesXDiaSemanaGuardar", parametros);
		}

		public static void TareasProgParametrosnEliminar(string /*0*/pTareaProgramada_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genTareasProgParametrosEliminar", parametros);
		}

		public static void TareasProgParametrosGuardar(int /*0*/pTareaProgramada_Id, string pParametro, string /*2*/pValor, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTareaProgramada_Id, /*1*/pParametro,  new Generalidades.NullableString(/*2*/pValor) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("genTareasProgParametrosGuardar", parametros);
		}




		public static genTareasProgramadasDS TareaParametrosDatos(string /*0*/pTarea_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTarea_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("genTareasParametrosDatos", parametros);

			string[] camposTabla0 = { "Valor" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			genTareasProgramadasDS dsTipado = new genTareasProgramadasDS();
			//string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.ConRepeticion.TableName, dsTipado.Diaria.TableName,
			//						dsTipado.Semanal.TableName, dsTipado.SemanalDias.TableName,
			//						dsTipado.Mensual.TableName, dsTipado.MensualMeses.TableName,
			//						dsTipado.MensualXDia.TableName, dsTipado.MensualXSemanas.TableName,
			//						dsTipado.MensualXDiaSemana.TableName, dsTipado.Parametros.TableName };
			//Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Parametros.Merge(ds.Tables[0]);
			return (dsTipado);
		}


		public static genTareasProgramadasTodasDS TodasDatos(int /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("genTareasProgramadasTodasDatos", parametros);

			string[] camposTabla0 = { "FechaFin", "HoraFin", "FechaUltEjecucion", "FechaProxEjecucion" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			genTareasProgramadasTodasDS dsTipado = new genTareasProgramadasTodasDS();
			dsTipado.Tareas.Merge(ds.Tables[0]);
			return (dsTipado);
		}



	}
}
