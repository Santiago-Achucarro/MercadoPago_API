using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class suePersonal
    {
		public static suePersonalDS Datos(int /*0*/pLegajo, DateTime /*1*/pFecha, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pFecha };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("suePersonalDatos", parametros);

			string[] camposTabla0 = { "Empresa_Id", "Nacionalidad", "DescripcionNacionalidad", "CodigoNatural", "DescripcionCodigoNatural", "FechaBaja", "Observaciones", "AvisarA", "Usuario_Id", "Actividad_Id", "DescripcionActividad", "Afore_Id", "DescripcionAfore", "Categoria_Id", "DescripcionCategoria", "CondServicio_Id", "DescripcionCondServicio", "Cuenta_Id", "DescripcionCuenta", "Convenio_Id", "Descripcionconvenio", "Direccion1", "CodigoPostal", "Direccion2", "EntreCalle1", "EntreCalle2", "Localidad", "NroExterior", "NroInterior", "Provincia_Id", "DescripcionProvincia", "EstadoCivil_Id", "DescripcionEdoCivil", "Localidad_Id", "DescripcionLocalidad", "ModContrata_Id", "DescripcionModContrata", "Puesto_Id", "DescripcionPuesto", "Siniestro_Id", "DescripcionSiniestro", "SituacionRevi_Id", "DescripcionSituacionRevi", "Sucursal", "DescripcionSucursal", "TipoContrato", "DescripcionTipoContrato", "TipoEmpleador_Id", "DescripcionTipoEmpleador", "TipoJornada", "DescripcionTipoJornada", "TipoPago_Id", "DescripcionTipoPago", "TipoRegimen", "DescripcionTipoRegimen", "TipoSDI", "DescripcionTipoSDI", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Porcentaje", "Fecha", "FechaOculta", "Rebaja", "Reduccion", "Adicional", "Voluntario", "ObraSocial", "DescObraSocial" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "DescripcionActividad", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "DescripcionAfore", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "Categoria_Id", "DescripcionCategorias" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			string[] camposTabla4 = { "DescripcionCondServicio", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

			string[] camposTabla5 = { "Usuario_Id", "Renglon" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

			string[] camposTabla6 = { "Cuenta_Id", "DescripcionCuentas", "Renglon" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

			string[] camposTabla7 = { "Convenio_Id", "DescripcionConvenio", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

			string[] camposTabla8 = { "Provincia_Id", "DescripcionProvincia" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

			string[] camposTabla9 = { "DescripcionEstadoCivil", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

			string[] camposTabla10 = { "DescripcionLocalidad", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

			string[] camposTabla11 = { "DescripcionModalidad_Id", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[11], camposTabla11);

			string[] camposTabla12 = { "Puesto_Id", "DescripcionPuesto", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[12], camposTabla12);

			string[] camposTabla13 = { "DescripcionSiniestro", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[13], camposTabla13);

			string[] camposTabla14 = { "DescripcionSituacion", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[14], camposTabla14);

			string[] camposTabla15 = { "Sucursal", "DescripcionSucursal", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[15], camposTabla15);

			string[] camposTabla16 = { "DescripcionTipoContrato", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[16], camposTabla16);

			string[] camposTabla17 = { "DescripcionTipoEmpleador", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[17], camposTabla17);

			string[] camposTabla18 = { "TipoJornada", "DescripcionTipoJornada", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[18], camposTabla18);

			string[] camposTabla19 = { "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[19], camposTabla19);

			string[] camposTabla20 = { "DescripcionTipoRegimen", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[20], camposTabla20);

			string[] camposTabla21 = { "DescripcionTipoSDI", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[21], camposTabla21);

			string[] camposTabla22 = { "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[22], camposTabla22);

			string[] camposTabla23 = { "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[23], camposTabla23);

			string[] camposTabla24 = { "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[24], camposTabla24);

			string[] camposTabla25 = { "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[25], camposTabla25);

			string[] camposTabla26 = { "DescripcionObraSocial", "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[26], camposTabla26);

			string[] camposTabla27 = { "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[27], camposTabla27);

			string[] camposTabla28 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[28], camposTabla28);

			suePersonalDS dsTipado = new suePersonalDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Actividades.TableName, dsTipado.Afore.TableName, dsTipado.Categorias.TableName, dsTipado.CondServicio.TableName, dsTipado.Contable.TableName, dsTipado.ContableDatos.TableName, dsTipado.Convenio.TableName, dsTipado.Domicilio.TableName, dsTipado.EdoCivil.TableName, dsTipado.Localidad.TableName, dsTipado.ModContrata.TableName, dsTipado.Puestos.TableName, dsTipado.Sinestrado.TableName, dsTipado.SituacionRevi.TableName, dsTipado.Sucursal.TableName, dsTipado.TipoContrato.TableName, dsTipado.TipoEmpleador.TableName, dsTipado.TipoJornada.TableName, dsTipado.TipoPago.TableName, dsTipado.TipoRegimen.TableName, dsTipado.TipoSDI.TableName, dsTipado.RebajaPromo.TableName, dsTipado.ReduccionZonal.TableName, dsTipado.AporteAdic.TableName, dsTipado.AporteVoluntario.TableName, dsTipado.ObraSocial.TableName, dsTipado.ContableExtencion.TableName, dsTipado.genAtributosGenerales.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

			public static void Eliminar(long /*0*/pgenEntidades, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("suePersonalEliminar", parametros);
        }


		public static void Guardar(long /*0*/pgenEntidades, int /*1*/pLegajo, int /*2*/pLegajo_Nuevo, int /*3*/pEmpresa_Id, string /*4*/pNombres, string /*5*/pApellidoPaterno, string /*6*/pApellidoMaterno, string /*7*/pNumeroDoc, string /*8*/pNroSegSocial, string /*9*/pTelefonos, string /*10*/pCelular, DateTime /*11*/pFechaNacimiento, string /*12*/pSexo, short /*13*/pNacionalidad_Id, string /*14*/pCodigoNatural, string /*15*/peMail, DateTime /*16*/pFechaIngreso, DateTime /*17*/pFechaBaja, int /*18*/pAniosReconocidos, int /*19*/pMesesReconocidos, string /*20*/pGrupoSanguineo, string /*21*/pRH, string /*22*/pBancoSucursal, string /*23*/pBancoCuenta, string /*24*/pBancoTipoCta, bool /*25*/pCuentaInactiva, string /*26*/pClaveBancaria, string /*27*/pObservaciones, string /*28*/pUMF, string /*29*/pAvisarA, bool /*30*/pInactivo, bool /*31*/pPosteado, DateTime /*32*/pFecha, int /*33*/pUsuario_Id, string /*34*/pActividad_Id, string /*35*/pAfore_Id, string /*36*/pCategoria_Id, string /*37*/pCondServicio, string /*38*/pConvenio_Id, string /*39*/pDireccion1, string /*40*/pDireccion2, string /*41*/pNroExterior, string /*42*/pNroInterior, string /*43*/pLocalidad, string /*44*/pCodigoPostal, string /*45*/pEntreCalle1, string /*46*/pEntreCalle2, string /*47*/pProvincia_Id, string /*48*/pEstadoCivil_Id, string /*49*/pLocalidad_Id, string /*50*/pModContrata_Id, string /*51*/pPuesto_Id, string /*52*/pSiniestro_Id, string /*53*/pSituacionRevi, string /*54*/pSucursal, string /*55*/pTipoContrato, string /*56*/pTipoEmpleador_Id, string /*57*/pTipoJornada, string /*58*/pTipoPago_Id, string /*59*/pTipoRegimen, string /*60*/pTipoSDI, decimal /*61*/pRebaja, decimal /*62*/pReduccion, decimal /*63*/pAdicional, decimal /*64*/pVoluntario, string /*65*/pObraSocial, string /*66*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pgenEntidades, /*1*/pLegajo, /*2*/pLegajo_Nuevo, new Generalidades.NullableInt(/*3*/pEmpresa_Id), /*4*/pNombres, /*5*/pApellidoPaterno, /*6*/pApellidoMaterno, /*7*/pNumeroDoc, /*8*/pNroSegSocial, /*9*/pTelefonos, /*10*/pCelular, /*11*/pFechaNacimiento, /*12*/pSexo, new Generalidades.NullableShort(/*13*/pNacionalidad_Id), new Generalidades.NullableString(/*14*/pCodigoNatural), /*15*/peMail, /*16*/pFechaIngreso, new Generalidades.NullableDate(/*17*/pFechaBaja), /*18*/pAniosReconocidos, /*19*/pMesesReconocidos, /*20*/pGrupoSanguineo, /*21*/pRH, /*22*/pBancoSucursal, /*23*/pBancoCuenta, /*24*/pBancoTipoCta, /*25*/pCuentaInactiva, /*26*/pClaveBancaria, new Generalidades.NullableString(/*27*/pObservaciones), /*28*/pUMF, new Generalidades.NullableString(/*29*/pAvisarA), /*30*/pInactivo, /*31*/pPosteado, /*32*/pFecha, new Generalidades.NullableInt(/*33*/pUsuario_Id), new Generalidades.NullableString(/*34*/pActividad_Id), new Generalidades.NullableString(/*35*/pAfore_Id), new Generalidades.NullableString(/*36*/pCategoria_Id), new Generalidades.NullableString(/*37*/pCondServicio), new Generalidades.NullableString(/*38*/pConvenio_Id), /*39*/pDireccion1, /*40*/pDireccion2, /*41*/pNroExterior, /*42*/pNroInterior, /*43*/pLocalidad, /*44*/pCodigoPostal, /*45*/pEntreCalle1, /*46*/pEntreCalle2, new Generalidades.NullableString(/*47*/pProvincia_Id), /*48*/pEstadoCivil_Id, new Generalidades.NullableString(/*49*/pLocalidad_Id), new Generalidades.NullableString(/*50*/pModContrata_Id), new Generalidades.NullableString(/*51*/pPuesto_Id), new Generalidades.NullableString(/*52*/pSiniestro_Id), new Generalidades.NullableString(/*53*/pSituacionRevi), new Generalidades.NullableString(/*54*/pSucursal), new Generalidades.NullableString(/*55*/pTipoContrato), new Generalidades.NullableString(/*56*/pTipoEmpleador_Id), new Generalidades.NullableString(/*57*/pTipoJornada), new Generalidades.NullableString(/*58*/pTipoPago_Id), new Generalidades.NullableString(/*59*/pTipoRegimen), /*60*/pTipoSDI, new Generalidades.NullableDecimal(/*61*/pRebaja), new Generalidades.NullableDecimal(/*62*/pReduccion), new Generalidades.NullableDecimal(/*63*/pAdicional), new Generalidades.NullableDecimal(/*64*/pVoluntario), new Generalidades.NullableString(/*65*/pObraSocial) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("suePersonalGuardar", parametros);
		}





		public static suePersEditableDS Editable(int /*0*/pLegajo, DateTime /*1*/pFecha, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pFecha };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("suePersEditable", parametros);

            string[] camposTabla0 = { "Editable" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            suePersEditableDS dsTipado = new suePersEditableDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
