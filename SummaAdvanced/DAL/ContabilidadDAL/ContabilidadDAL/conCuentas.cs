using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conCuentas
    {

        public static conCuentasActualizacionDS ActualizacionDatos(string /*0*/pCuenta_Id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuenta_Id, /*1*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conCuentasActualizacionDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Tipo_Id", "Rubro_Id", "TipoRubro", "Base_Id", "Grupo_Id", "Cuadro1Fila_Id", "ReservadaPor", "Fecha_Reserva", "SubCuenta_Id", "Rubro_Balance", "Notas", "Moneda_Id", "Indice_Id", "TipoSAT_Id", "DescripcionconBaseDistri", "DescripcionconCuadro1Filas", "DescripcionconGruposCont", "DescripcionconRubros", "DescripcionconSituPatri", "DescripcionconSubCuentas", "DescripcionconTiposContables", "DescripcionconTiposSAT", "DescripcionIndicesAjustes", "DescripcionEmpresa", "DescripciongenMonedas", "CuentaSC", "DescripcionSC", "PorSubCuenta", "RubroAxi_Id", "DescripcionRubroAxi" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Marca", "TipoSAT_Id", "Base_Id", "DescripcionTipoSat", "DescripcionBaseDistri", "Inactivo", "Grupo_Id", "DescripcionGrupo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conCuentasActualizacionDS dsTipado = new conCuentasActualizacionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.SubCuentas.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static conCuentasDS Datos(string /*0*/pCuenta_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuenta_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conCuentasDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Tipo_Id", "Rubro_Id", "Base_Id", "Grupo_Id", "Cuadro1Fila_Id", "ReservadaPor", "Fecha_Reserva", "SubCuenta_Id", "Rubro_Balance", "Notas", "Moneda_Id", "Indice_Id", "TipoSAT_Id", "DescripcionconBaseDistri", "DescripcionconCuadro1Filas", "DescripcionconGruposCont", "DescripcionconRubros", "DescripcionconSituPatri", "DescripcionconSubCuentas", "DescripcionconTiposContables", "DescripcionconTiposSAT", "DescripcionIndicesAjustes", "DescripcionEmpresa", "DescripciongenMonedas", "RubroAxi_Id", "DescripcionRubroAxi" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            conCuentasDS dsTipado = new conCuentasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pCuenta_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuenta_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conCuentasEliminar", parametros);
        }


        public static int Guardar(string /*0*/pCuenta_Id, string /*1*/pCuenta_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pTipo_Id,
                string /*4*/pDescripcion, string /*5*/pRubro_Id, bool /*6*/pImputable, int /*7*/pNivel, string /*8*/pBase_Id, string /*9*/pGrupo_Id, int /*10*/pCuadro1Fila_Id, string /*11*/pReservadaPor, DateTime /*12*/pFecha_Reserva, string /*13*/pSubCuenta_Id, bool /*14*/pNoSeReserva, string /*15*/pRubro_Balance, bool /*16*/pAjustable, string /*17*/pNotas, string /*18*/pMoneda_Id, string /*19*/pIndice_Id, short /*20*/pMetodo, bool /*21*/pEliminaConsolida, string /*22*/pTipoSAT_Id, string /*23*/pNaturaleza, bool /*24*/pInactivo, int /*25*/pUsuario_Id, bool /*26*/pPosteado, string /*27*/pDescription, int /*28*/pRubroAxi_Id, string /*29*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuenta_Id, /*1*/pCuenta_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id),
                new Generalidades.NullableString(/*3*/pTipo_Id), /*4*/pDescripcion, new Generalidades.NullableString(/*5*/pRubro_Id), 
                /*6*/pImputable, /*7*/pNivel, new Generalidades.NullableString(/*8*/pBase_Id),
                new Generalidades.NullableString(/*9*/pGrupo_Id), new Generalidades.NullableInt(/*10*/pCuadro1Fila_Id),
                new Generalidades.NullableString(/*11*/pReservadaPor), /*12*/new Generalidades.NullableDate(pFecha_Reserva), new Generalidades.NullableString(/*13*/pSubCuenta_Id), /*14*/pNoSeReserva, new Generalidades.NullableString(/*15*/pRubro_Balance), /*16*/pAjustable, new Generalidades.NullableString(/*17*/pNotas), new Generalidades.NullableString(/*18*/pMoneda_Id), new Generalidades.NullableString(/*19*/pIndice_Id), /*20*/pMetodo, /*21*/pEliminaConsolida, new Generalidades.NullableString(/*22*/pTipoSAT_Id), /*23*/pNaturaleza, /*24*/pInactivo, /*25*/pUsuario_Id, /*26*/pPosteado, /*27*/pDescription, new Generalidades.NullableInt(/*28*/pRubroAxi_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int)oiDAAB.guardar("conCuentasGuardar", parametros);
        }

        public static conVeriCentro12DS DatosVeriCentro12(string /*0*/pCuenta_Id, string /*1*/pCentro1_Id, string /*2*/pCentro2_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuenta_Id, /*1*/pCentro1_Id, /*2*/pCentro2_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conVeriCentro12Datos", parametros);

            conVeriCentro12DS dsTipado = new conVeriCentro12DS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static conCuentasCuentasDS DatosCuantas(string /*0*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conCuentasCuentasDatos", parametros);

            string[] camposTabla0 = { "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            conCuentasCuentasDS dsTipado = new conCuentasCuentasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}