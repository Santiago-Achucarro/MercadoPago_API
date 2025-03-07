using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venSTMAfip
    {
        public static venSubTipoMovDS Datos(string /*0*/pSubTipoMov_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSubTipoMov_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venSubTipoMovDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Signo", "TipoMovResumido", "venTipoMov", "DescripcionTipoMov",
                "SegmentoRemito_Id", "DescripcionSegmentos", "UsuarioAutorizado", "DescripcionUsuarioAutorizado", "Centro1_Id",
                "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "CtaDefecto", "DescripcionCtaDefecto", "CtaOtrosCargos",
                "DescripcionCtaOtrosCargos", "CodigoFormulario" };

            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Comprobante_Id", "DescripcionTiposCompAfip" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            venSubTipoMovDS dsTipado = new venSubTipoMovDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName,
                dsTipado.venSTMAfip.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pVenSubTipoMov, string /*1*/pLetra, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pVenSubTipoMov, new Generalidades.NullableString(/*1*/pLetra) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venSTMAfipEliminar", parametros);
        }

        public static void Guardar(int /*0*/pvenSubTipoMov, string /*1*/pLetra, int /*2*/pComprobante_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenSubTipoMov, /*1*/pLetra, /*2*/pComprobante_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venSTMAfipGuardar", parametros);
        }
    }
}
