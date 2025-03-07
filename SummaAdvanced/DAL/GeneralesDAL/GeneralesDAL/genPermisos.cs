using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genPermisos
    {
        public static genPermisosDS Datos(int /*0*/pUsuario_Id, int /*1*/pEmpresa_id, string /*2*/pFormulario_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id, /*1*/pEmpresa_id, new Generalidades.NullableString(/*2*/pFormulario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genPermisosDatos", parametros);

            string[] camposTabla0 = { "PTodasEmpresas", "Consultar", "Actualizar", "Borrar", "Postear" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genPermisosDS dsTipado = new genPermisosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pUsuario_Id, string /*1*/pFormulario, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id, /*1*/new Generalidades.NullableString(pFormulario) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genPermisosEliminar", parametros);
        }
        public static void Guardar(string /*0*/pUsuario_Id,  string /*2*/pFormulario, int Empresa_id, bool /*3*/pConsultar, bool  /*4*/pActualizar, bool  /*5*/pBorrar, bool /*6*/pPostear, bool /*7*/ pModificaCodigos, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id, /*2*/pFormulario, new Generalidades.NullableInt(Empresa_id), /*3*/pConsultar, /*4*/pActualizar, /*5*/pBorrar, /*6*/pPostear, /*7*/ pModificaCodigos };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genPermisosGuardar", parametros);
        }

        public static genPermisosDatosTodosDS DatosTodos(string /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genPermisosDatosTodos", parametros);

            string[] camposTabla1 = { "Empresa_id", "Consultar", "Actualizar", "Borrar", "Postear", "ModificaCodigos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genPermisosDatosTodosDS dsTipado = new genPermisosDatosTodosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Permisos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static genPermisosUsuarioDS DatosUsuario(string /*0*/pUsuario_id, string /*1*/pDominio_Id, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_id, /*1*/pDominio_Id, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genPermisosUsuarioDatos", parametros);

            string[] camposTabla1 = { "OrdenPadre", "Formulario_Id", "Opcion", "Consultar", "Actualizar", "Borrar", "Postear", "ModificaCodigos", "ParaTodasLasEmpresas", "ConsultarA", "ActualizarA", "BorrarA", "PostearA", "ModificaCodigosA", "ParaTodasLasEmpresasA" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Marcado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            genPermisosUsuarioDS dsTipado = new genPermisosUsuarioDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Permisos.TableName, dsTipado.Especiales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void EliminarUsuario(string /*0*/pUsuario_id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_id, /*1*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genPermisosUsuarioEliminar", parametros);
        }
        public static void Copiar(string /*0*/pUsuario_id, string /*1*/pUsuarioN_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_id, /*1*/pUsuarioN_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genPermisosCopiar", parametros);
        }


    }
}
